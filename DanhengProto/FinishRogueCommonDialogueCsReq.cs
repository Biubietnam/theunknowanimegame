using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000593 RID: 1427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishRogueCommonDialogueCsReq : IMessage<FinishRogueCommonDialogueCsReq>, IMessage, IEquatable<FinishRogueCommonDialogueCsReq>, IDeepCloneable<FinishRogueCommonDialogueCsReq>, IBufferMessage
	{
		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x000ADAA5 File Offset: 0x000ABCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishRogueCommonDialogueCsReq> Parser
		{
			get
			{
				return FinishRogueCommonDialogueCsReq._parser;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x000ADAAC File Offset: 0x000ABCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishRogueCommonDialogueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x000ADABE File Offset: 0x000ABCBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishRogueCommonDialogueCsReq.Descriptor;
			}
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000ADAC5 File Offset: 0x000ABCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueCsReq()
		{
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x000ADACD File Offset: 0x000ABCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueCsReq(FinishRogueCommonDialogueCsReq other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000ADAF2 File Offset: 0x000ABCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueCsReq Clone()
		{
			return new FinishRogueCommonDialogueCsReq(this);
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x000ADAFA File Offset: 0x000ABCFA
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x000ADB02 File Offset: 0x000ABD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x000ADB0B File Offset: 0x000ABD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishRogueCommonDialogueCsReq);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000ADB19 File Offset: 0x000ABD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishRogueCommonDialogueCsReq other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x000ADB48 File Offset: 0x000ABD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x000ADB87 File Offset: 0x000ABD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x000ADB8F File Offset: 0x000ABD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x000ADB98 File Offset: 0x000ABD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000ADBCC File Offset: 0x000ABDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x000ADC0A File Offset: 0x000ABE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishRogueCommonDialogueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x000ADC3B File Offset: 0x000ABE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000ADC44 File Offset: 0x000ABE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventUniqueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001954 RID: 6484
		private static readonly MessageParser<FinishRogueCommonDialogueCsReq> _parser = new MessageParser<FinishRogueCommonDialogueCsReq>(() => new FinishRogueCommonDialogueCsReq());

		// Token: 0x04001955 RID: 6485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001956 RID: 6486
		public const int EventUniqueIdFieldNumber = 10;

		// Token: 0x04001957 RID: 6487
		private uint eventUniqueId_;
	}
}
