using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B3 RID: 5043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TutorialGuide : IMessage<TutorialGuide>, IMessage, IEquatable<TutorialGuide>, IDeepCloneable<TutorialGuide>, IBufferMessage
	{
		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0600E0E9 RID: 57577 RVA: 0x00256BD1 File Offset: 0x00254DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TutorialGuide> Parser
		{
			get
			{
				return TutorialGuide._parser;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0600E0EA RID: 57578 RVA: 0x00256BD8 File Offset: 0x00254DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TutorialGuideReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0600E0EB RID: 57579 RVA: 0x00256BEA File Offset: 0x00254DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialGuide.Descriptor;
			}
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x00256BF1 File Offset: 0x00254DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialGuide()
		{
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x00256BF9 File Offset: 0x00254DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialGuide(TutorialGuide other) : this()
		{
			this.status_ = other.status_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x00256C2A File Offset: 0x00254E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialGuide Clone()
		{
			return new TutorialGuide(this);
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0600E0EF RID: 57583 RVA: 0x00256C32 File Offset: 0x00254E32
		// (set) Token: 0x0600E0F0 RID: 57584 RVA: 0x00256C3A File Offset: 0x00254E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x00256C43 File Offset: 0x00254E43
		// (set) Token: 0x0600E0F2 RID: 57586 RVA: 0x00256C4B File Offset: 0x00254E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x00256C54 File Offset: 0x00254E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialGuide);
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x00256C62 File Offset: 0x00254E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialGuide other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x00256CA0 File Offset: 0x00254EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != TutorialStatus.TutorialNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0F6 RID: 57590 RVA: 0x00256CFE File Offset: 0x00254EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E0F7 RID: 57591 RVA: 0x00256D06 File Offset: 0x00254F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0F8 RID: 57592 RVA: 0x00256D10 File Offset: 0x00254F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this.Status != TutorialStatus.TutorialNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0F9 RID: 57593 RVA: 0x00256D6C File Offset: 0x00254F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != TutorialStatus.TutorialNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0FA RID: 57594 RVA: 0x00256DC4 File Offset: 0x00254FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialGuide other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != TutorialStatus.TutorialNone)
			{
				this.Status = other.Status;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0FB RID: 57595 RVA: 0x00256E14 File Offset: 0x00255014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0FC RID: 57596 RVA: 0x00256E20 File Offset: 0x00255020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (TutorialStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400598C RID: 22924
		private static readonly MessageParser<TutorialGuide> _parser = new MessageParser<TutorialGuide>(() => new TutorialGuide());

		// Token: 0x0400598D RID: 22925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400598E RID: 22926
		public const int StatusFieldNumber = 5;

		// Token: 0x0400598F RID: 22927
		private TutorialStatus status_;

		// Token: 0x04005990 RID: 22928
		public const int IdFieldNumber = 3;

		// Token: 0x04005991 RID: 22929
		private uint id_;
	}
}
