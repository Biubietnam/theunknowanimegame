using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055F RID: 1375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishAeonDialogueGroupCsReq : IMessage<FinishAeonDialogueGroupCsReq>, IMessage, IEquatable<FinishAeonDialogueGroupCsReq>, IDeepCloneable<FinishAeonDialogueGroupCsReq>, IBufferMessage
	{
		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x000A7E58 File Offset: 0x000A6058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishAeonDialogueGroupCsReq> Parser
		{
			get
			{
				return FinishAeonDialogueGroupCsReq._parser;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000A7E5F File Offset: 0x000A605F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x000A7E71 File Offset: 0x000A6071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupCsReq.Descriptor;
			}
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x000A7E78 File Offset: 0x000A6078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupCsReq()
		{
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x000A7E80 File Offset: 0x000A6080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupCsReq(FinishAeonDialogueGroupCsReq other) : this()
		{
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x000A7EA5 File Offset: 0x000A60A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishAeonDialogueGroupCsReq Clone()
		{
			return new FinishAeonDialogueGroupCsReq(this);
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x000A7EAD File Offset: 0x000A60AD
		// (set) Token: 0x06003D53 RID: 15699 RVA: 0x000A7EB5 File Offset: 0x000A60B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x000A7EBE File Offset: 0x000A60BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishAeonDialogueGroupCsReq);
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x000A7ECC File Offset: 0x000A60CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishAeonDialogueGroupCsReq other)
		{
			return other != null && (other == this || (this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x000A7EFC File Offset: 0x000A60FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x000A7F3B File Offset: 0x000A613B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x000A7F43 File Offset: 0x000A6143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x000A7F4C File Offset: 0x000A614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x000A7F80 File Offset: 0x000A6180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x000A7FBE File Offset: 0x000A61BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishAeonDialogueGroupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x000A7FEF File Offset: 0x000A61EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x000A7FF8 File Offset: 0x000A61F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AeonId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400188B RID: 6283
		private static readonly MessageParser<FinishAeonDialogueGroupCsReq> _parser = new MessageParser<FinishAeonDialogueGroupCsReq>(() => new FinishAeonDialogueGroupCsReq());

		// Token: 0x0400188C RID: 6284
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400188D RID: 6285
		public const int AeonIdFieldNumber = 12;

		// Token: 0x0400188E RID: 6286
		private uint aeonId_;
	}
}
