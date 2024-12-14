using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004DF RID: 1247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRogueRewardKeyCsReq : IMessage<ExchangeRogueRewardKeyCsReq>, IMessage, IEquatable<ExchangeRogueRewardKeyCsReq>, IDeepCloneable<ExchangeRogueRewardKeyCsReq>, IBufferMessage
	{
		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x00098EB4 File Offset: 0x000970B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRogueRewardKeyCsReq> Parser
		{
			get
			{
				return ExchangeRogueRewardKeyCsReq._parser;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x00098EBB File Offset: 0x000970BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeRogueRewardKeyCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x00098ECD File Offset: 0x000970CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRogueRewardKeyCsReq.Descriptor;
			}
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00098ED4 File Offset: 0x000970D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyCsReq()
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00098EDC File Offset: 0x000970DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyCsReq(ExchangeRogueRewardKeyCsReq other) : this()
		{
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00098F01 File Offset: 0x00097101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyCsReq Clone()
		{
			return new ExchangeRogueRewardKeyCsReq(this);
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x00098F09 File Offset: 0x00097109
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x00098F11 File Offset: 0x00097111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00098F1A File Offset: 0x0009711A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRogueRewardKeyCsReq);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00098F28 File Offset: 0x00097128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRogueRewardKeyCsReq other)
		{
			return other != null && (other == this || (this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00098F58 File Offset: 0x00097158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00098F97 File Offset: 0x00097197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00098F9F File Offset: 0x0009719F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00098FA8 File Offset: 0x000971A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00098FDC File Offset: 0x000971DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0009901A File Offset: 0x0009721A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRogueRewardKeyCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x0009904B File Offset: 0x0009724B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00099054 File Offset: 0x00097254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Count = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001613 RID: 5651
		private static readonly MessageParser<ExchangeRogueRewardKeyCsReq> _parser = new MessageParser<ExchangeRogueRewardKeyCsReq>(() => new ExchangeRogueRewardKeyCsReq());

		// Token: 0x04001614 RID: 5652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001615 RID: 5653
		public const int CountFieldNumber = 3;

		// Token: 0x04001616 RID: 5654
		private uint count_;
	}
}
