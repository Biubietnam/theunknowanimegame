using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B5 RID: 1205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildReRandomStageCsReq : IMessage<EvolveBuildReRandomStageCsReq>, IMessage, IEquatable<EvolveBuildReRandomStageCsReq>, IDeepCloneable<EvolveBuildReRandomStageCsReq>, IBufferMessage
	{
		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x0009454C File Offset: 0x0009274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildReRandomStageCsReq> Parser
		{
			get
			{
				return EvolveBuildReRandomStageCsReq._parser;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x00094553 File Offset: 0x00092753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildReRandomStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x00094565 File Offset: 0x00092765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildReRandomStageCsReq.Descriptor;
			}
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0009456C File Offset: 0x0009276C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageCsReq()
		{
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00094574 File Offset: 0x00092774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageCsReq(EvolveBuildReRandomStageCsReq other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00094599 File Offset: 0x00092799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageCsReq Clone()
		{
			return new EvolveBuildReRandomStageCsReq(this);
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000945A1 File Offset: 0x000927A1
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x000945A9 File Offset: 0x000927A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x000945B2 File Offset: 0x000927B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildReRandomStageCsReq);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x000945C0 File Offset: 0x000927C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildReRandomStageCsReq other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000945F0 File Offset: 0x000927F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0009462F File Offset: 0x0009282F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00094637 File Offset: 0x00092837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00094640 File Offset: 0x00092840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00094674 File Offset: 0x00092874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000946B2 File Offset: 0x000928B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildReRandomStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x000946E3 File Offset: 0x000928E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x000946EC File Offset: 0x000928EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001578 RID: 5496
		private static readonly MessageParser<EvolveBuildReRandomStageCsReq> _parser = new MessageParser<EvolveBuildReRandomStageCsReq>(() => new EvolveBuildReRandomStageCsReq());

		// Token: 0x04001579 RID: 5497
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400157A RID: 5498
		public const int LevelIdFieldNumber = 13;

		// Token: 0x0400157B RID: 5499
		private uint levelId_;
	}
}
