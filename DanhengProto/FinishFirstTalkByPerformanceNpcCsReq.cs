using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200057B RID: 1403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishFirstTalkByPerformanceNpcCsReq : IMessage<FinishFirstTalkByPerformanceNpcCsReq>, IMessage, IEquatable<FinishFirstTalkByPerformanceNpcCsReq>, IDeepCloneable<FinishFirstTalkByPerformanceNpcCsReq>, IBufferMessage
	{
		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x000AB291 File Offset: 0x000A9491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishFirstTalkByPerformanceNpcCsReq> Parser
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcCsReq._parser;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x000AB298 File Offset: 0x000A9498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x000AB2AA File Offset: 0x000A94AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcCsReq.Descriptor;
			}
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x000AB2B1 File Offset: 0x000A94B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcCsReq()
		{
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x000AB2B9 File Offset: 0x000A94B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcCsReq(FinishFirstTalkByPerformanceNpcCsReq other) : this()
		{
			this.performanceId_ = other.performanceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x000AB2DE File Offset: 0x000A94DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcCsReq Clone()
		{
			return new FinishFirstTalkByPerformanceNpcCsReq(this);
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x000AB2E6 File Offset: 0x000A94E6
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x000AB2EE File Offset: 0x000A94EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PerformanceId
		{
			get
			{
				return this.performanceId_;
			}
			set
			{
				this.performanceId_ = value;
			}
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x000AB2F7 File Offset: 0x000A94F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishFirstTalkByPerformanceNpcCsReq);
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x000AB305 File Offset: 0x000A9505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishFirstTalkByPerformanceNpcCsReq other)
		{
			return other != null && (other == this || (this.PerformanceId == other.PerformanceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x000AB334 File Offset: 0x000A9534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PerformanceId != 0U)
			{
				num ^= this.PerformanceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x000AB373 File Offset: 0x000A9573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x000AB37B File Offset: 0x000A957B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x000AB384 File Offset: 0x000A9584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PerformanceId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PerformanceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x000AB3B8 File Offset: 0x000A95B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PerformanceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PerformanceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x000AB3F6 File Offset: 0x000A95F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishFirstTalkByPerformanceNpcCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PerformanceId != 0U)
			{
				this.PerformanceId = other.PerformanceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x000AB427 File Offset: 0x000A9627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x000AB430 File Offset: 0x000A9630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PerformanceId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018FC RID: 6396
		private static readonly MessageParser<FinishFirstTalkByPerformanceNpcCsReq> _parser = new MessageParser<FinishFirstTalkByPerformanceNpcCsReq>(() => new FinishFirstTalkByPerformanceNpcCsReq());

		// Token: 0x040018FD RID: 6397
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018FE RID: 6398
		public const int PerformanceIdFieldNumber = 5;

		// Token: 0x040018FF RID: 6399
		private uint performanceId_;
	}
}
