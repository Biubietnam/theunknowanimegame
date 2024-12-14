using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B1 RID: 5041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Tutorial : IMessage<Tutorial>, IMessage, IEquatable<Tutorial>, IDeepCloneable<Tutorial>, IBufferMessage
	{
		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x0025688C File Offset: 0x00254A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Tutorial> Parser
		{
			get
			{
				return Tutorial._parser;
			}
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0600E0D3 RID: 57555 RVA: 0x00256893 File Offset: 0x00254A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TutorialReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x002568A5 File Offset: 0x00254AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Tutorial.Descriptor;
			}
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x002568AC File Offset: 0x00254AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Tutorial()
		{
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x002568B4 File Offset: 0x00254AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Tutorial(Tutorial other) : this()
		{
			this.status_ = other.status_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x002568E5 File Offset: 0x00254AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Tutorial Clone()
		{
			return new Tutorial(this);
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x002568ED File Offset: 0x00254AED
		// (set) Token: 0x0600E0D9 RID: 57561 RVA: 0x002568F5 File Offset: 0x00254AF5
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

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x002568FE File Offset: 0x00254AFE
		// (set) Token: 0x0600E0DB RID: 57563 RVA: 0x00256906 File Offset: 0x00254B06
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

		// Token: 0x0600E0DC RID: 57564 RVA: 0x0025690F File Offset: 0x00254B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Tutorial);
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x0025691D File Offset: 0x00254B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Tutorial other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x0025695C File Offset: 0x00254B5C
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

		// Token: 0x0600E0DF RID: 57567 RVA: 0x002569BA File Offset: 0x00254BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x002569C2 File Offset: 0x00254BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x002569CC File Offset: 0x00254BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != TutorialStatus.TutorialNone)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x00256A28 File Offset: 0x00254C28
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

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x00256A80 File Offset: 0x00254C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Tutorial other)
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

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x00256AD0 File Offset: 0x00254CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x00256ADC File Offset: 0x00254CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Status = (TutorialStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005985 RID: 22917
		private static readonly MessageParser<Tutorial> _parser = new MessageParser<Tutorial>(() => new Tutorial());

		// Token: 0x04005986 RID: 22918
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005987 RID: 22919
		public const int StatusFieldNumber = 7;

		// Token: 0x04005988 RID: 22920
		private TutorialStatus status_;

		// Token: 0x04005989 RID: 22921
		public const int IdFieldNumber = 11;

		// Token: 0x0400598A RID: 22922
		private uint id_;
	}
}
