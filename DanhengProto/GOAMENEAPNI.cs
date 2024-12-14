using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086F RID: 2159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GOAMENEAPNI : IMessage<GOAMENEAPNI>, IMessage, IEquatable<GOAMENEAPNI>, IDeepCloneable<GOAMENEAPNI>, IBufferMessage
	{
		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x000FD9AC File Offset: 0x000FBBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GOAMENEAPNI> Parser
		{
			get
			{
				return GOAMENEAPNI._parser;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x000FD9B3 File Offset: 0x000FBBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GOAMENEAPNIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x000FD9C5 File Offset: 0x000FBBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GOAMENEAPNI.Descriptor;
			}
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x000FD9CC File Offset: 0x000FBBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOAMENEAPNI()
		{
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x000FD9D4 File Offset: 0x000FBBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOAMENEAPNI(GOAMENEAPNI other) : this()
		{
			this.dialogueId_ = other.dialogueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x000FD9F9 File Offset: 0x000FBBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOAMENEAPNI Clone()
		{
			return new GOAMENEAPNI(this);
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x000FDA01 File Offset: 0x000FBC01
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x000FDA09 File Offset: 0x000FBC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x000FDA12 File Offset: 0x000FBC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GOAMENEAPNI);
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x000FDA20 File Offset: 0x000FBC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GOAMENEAPNI other)
		{
			return other != null && (other == this || (this.DialogueId == other.DialogueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x000FDA50 File Offset: 0x000FBC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x000FDA8F File Offset: 0x000FBC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x000FDA97 File Offset: 0x000FBC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x000FDAA0 File Offset: 0x000FBCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x000FDB12 File Offset: 0x000FBD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GOAMENEAPNI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x000FDB43 File Offset: 0x000FBD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x000FDB4C File Offset: 0x000FBD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024DF RID: 9439
		private static readonly MessageParser<GOAMENEAPNI> _parser = new MessageParser<GOAMENEAPNI>(() => new GOAMENEAPNI());

		// Token: 0x040024E0 RID: 9440
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024E1 RID: 9441
		public const int DialogueIdFieldNumber = 11;

		// Token: 0x040024E2 RID: 9442
		private uint dialogueId_;
	}
}
