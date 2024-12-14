using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B0F RID: 2831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyCellUpdateNotify : IMessage<MonopolyCellUpdateNotify>, IMessage, IEquatable<MonopolyCellUpdateNotify>, IDeepCloneable<MonopolyCellUpdateNotify>, IBufferMessage
	{
		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06007D54 RID: 32084 RVA: 0x0014BD85 File Offset: 0x00149F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyCellUpdateNotify> Parser
		{
			get
			{
				return MonopolyCellUpdateNotify._parser;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x0014BD8C File Offset: 0x00149F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyCellUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x0014BD9E File Offset: 0x00149F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyCellUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x0014BDA5 File Offset: 0x00149FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCellUpdateNotify()
		{
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x0014BDAD File Offset: 0x00149FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCellUpdateNotify(MonopolyCellUpdateNotify other) : this()
		{
			this.gGMHDPCMGFP_ = ((other.gGMHDPCMGFP_ != null) ? other.gGMHDPCMGFP_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0014BDE2 File Offset: 0x00149FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCellUpdateNotify Clone()
		{
			return new MonopolyCellUpdateNotify(this);
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x0014BDEA File Offset: 0x00149FEA
		// (set) Token: 0x06007D5B RID: 32091 RVA: 0x0014BDF2 File Offset: 0x00149FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL GGMHDPCMGFP
		{
			get
			{
				return this.gGMHDPCMGFP_;
			}
			set
			{
				this.gGMHDPCMGFP_ = value;
			}
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x0014BDFB File Offset: 0x00149FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyCellUpdateNotify);
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x0014BE09 File Offset: 0x0014A009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyCellUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GGMHDPCMGFP, other.GGMHDPCMGFP) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x0014BE3C File Offset: 0x0014A03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gGMHDPCMGFP_ != null)
			{
				num ^= this.GGMHDPCMGFP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x0014BE78 File Offset: 0x0014A078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D60 RID: 32096 RVA: 0x0014BE80 File Offset: 0x0014A080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x0014BE89 File Offset: 0x0014A089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gGMHDPCMGFP_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GGMHDPCMGFP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x0014BEBC File Offset: 0x0014A0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gGMHDPCMGFP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GGMHDPCMGFP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x0014BEFC File Offset: 0x0014A0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyCellUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gGMHDPCMGFP_ != null)
			{
				if (this.gGMHDPCMGFP_ == null)
				{
					this.GGMHDPCMGFP = new DHAIJMPAJDL();
				}
				this.GGMHDPCMGFP.MergeFrom(other.GGMHDPCMGFP);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x0014BF50 File Offset: 0x0014A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x0014BF5C File Offset: 0x0014A15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gGMHDPCMGFP_ == null)
					{
						this.GGMHDPCMGFP = new DHAIJMPAJDL();
					}
					input.ReadMessage(this.GGMHDPCMGFP);
				}
			}
		}

		// Token: 0x0400302B RID: 12331
		private static readonly MessageParser<MonopolyCellUpdateNotify> _parser = new MessageParser<MonopolyCellUpdateNotify>(() => new MonopolyCellUpdateNotify());

		// Token: 0x0400302C RID: 12332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400302D RID: 12333
		public const int GGMHDPCMGFPFieldNumber = 13;

		// Token: 0x0400302E RID: 12334
		private DHAIJMPAJDL gGMHDPCMGFP_;
	}
}
