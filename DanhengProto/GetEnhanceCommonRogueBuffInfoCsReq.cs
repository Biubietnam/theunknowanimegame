using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000687 RID: 1671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetEnhanceCommonRogueBuffInfoCsReq : IMessage<GetEnhanceCommonRogueBuffInfoCsReq>, IMessage, IEquatable<GetEnhanceCommonRogueBuffInfoCsReq>, IDeepCloneable<GetEnhanceCommonRogueBuffInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x000CBC35 File Offset: 0x000C9E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetEnhanceCommonRogueBuffInfoCsReq> Parser
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoCsReq._parser;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x000CBC3C File Offset: 0x000C9E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x000CBC4E File Offset: 0x000C9E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetEnhanceCommonRogueBuffInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x000CBC55 File Offset: 0x000C9E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoCsReq()
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x000CBC5D File Offset: 0x000C9E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoCsReq(GetEnhanceCommonRogueBuffInfoCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x000CBC82 File Offset: 0x000C9E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetEnhanceCommonRogueBuffInfoCsReq Clone()
		{
			return new GetEnhanceCommonRogueBuffInfoCsReq(this);
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x000CBC8A File Offset: 0x000C9E8A
		// (set) Token: 0x06004AE7 RID: 19175 RVA: 0x000CBC92 File Offset: 0x000C9E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x000CBC9B File Offset: 0x000C9E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetEnhanceCommonRogueBuffInfoCsReq);
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x000CBCA9 File Offset: 0x000C9EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetEnhanceCommonRogueBuffInfoCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x000CBCD8 File Offset: 0x000C9ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x000CBD17 File Offset: 0x000C9F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x000CBD1F File Offset: 0x000C9F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x000CBD28 File Offset: 0x000C9F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x000CBD5C File Offset: 0x000C9F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x000CBD9A File Offset: 0x000C9F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetEnhanceCommonRogueBuffInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x000CBDCB File Offset: 0x000C9FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x000CBDD4 File Offset: 0x000C9FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001DB8 RID: 7608
		private static readonly MessageParser<GetEnhanceCommonRogueBuffInfoCsReq> _parser = new MessageParser<GetEnhanceCommonRogueBuffInfoCsReq>(() => new GetEnhanceCommonRogueBuffInfoCsReq());

		// Token: 0x04001DB9 RID: 7609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DBA RID: 7610
		public const int InteractedPropEntityIdFieldNumber = 7;

		// Token: 0x04001DBB RID: 7611
		private uint interactedPropEntityId_;
	}
}
