using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000569 RID: 1385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishChessRogueSubStoryCsReq : IMessage<FinishChessRogueSubStoryCsReq>, IMessage, IEquatable<FinishChessRogueSubStoryCsReq>, IDeepCloneable<FinishChessRogueSubStoryCsReq>, IBufferMessage
	{
		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x000A8FA7 File Offset: 0x000A71A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishChessRogueSubStoryCsReq> Parser
		{
			get
			{
				return FinishChessRogueSubStoryCsReq._parser;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x000A8FAE File Offset: 0x000A71AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x000A8FC0 File Offset: 0x000A71C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishChessRogueSubStoryCsReq.Descriptor;
			}
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000A8FC7 File Offset: 0x000A71C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryCsReq()
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000A8FCF File Offset: 0x000A71CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryCsReq(FinishChessRogueSubStoryCsReq other) : this()
		{
			this.gKEJFEAKPAH_ = other.gKEJFEAKPAH_;
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000A900C File Offset: 0x000A720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChessRogueSubStoryCsReq Clone()
		{
			return new FinishChessRogueSubStoryCsReq(this);
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x000A9014 File Offset: 0x000A7214
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x000A901C File Offset: 0x000A721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKEJFEAKPAH
		{
			get
			{
				return this.gKEJFEAKPAH_;
			}
			set
			{
				this.gKEJFEAKPAH_ = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x000A9025 File Offset: 0x000A7225
		// (set) Token: 0x06003DC8 RID: 15816 RVA: 0x000A902D File Offset: 0x000A722D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LONLLBIHMID
		{
			get
			{
				return this.lONLLBIHMID_;
			}
			set
			{
				this.lONLLBIHMID_ = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x000A9036 File Offset: 0x000A7236
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x000A903E File Offset: 0x000A723E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueSubStoryId
		{
			get
			{
				return this.chessRogueSubStoryId_;
			}
			set
			{
				this.chessRogueSubStoryId_ = value;
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x000A9047 File Offset: 0x000A7247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishChessRogueSubStoryCsReq);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x000A9058 File Offset: 0x000A7258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishChessRogueSubStoryCsReq other)
		{
			return other != null && (other == this || (this.GKEJFEAKPAH == other.GKEJFEAKPAH && this.LONLLBIHMID == other.LONLLBIHMID && this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x000A90B4 File Offset: 0x000A72B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GKEJFEAKPAH != 0U)
			{
				num ^= this.GKEJFEAKPAH.GetHashCode();
			}
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x000A9125 File Offset: 0x000A7325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x000A912D File Offset: 0x000A732D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000A9138 File Offset: 0x000A7338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GKEJFEAKPAH != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GKEJFEAKPAH);
			}
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x000A91B0 File Offset: 0x000A73B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GKEJFEAKPAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKEJFEAKPAH);
			}
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x000A9220 File Offset: 0x000A7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishChessRogueSubStoryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GKEJFEAKPAH != 0U)
			{
				this.GKEJFEAKPAH = other.GKEJFEAKPAH;
			}
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x000A9284 File Offset: 0x000A7484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000A9290 File Offset: 0x000A7490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChessRogueSubStoryId = input.ReadUInt32();
						}
					}
					else
					{
						this.LONLLBIHMID = input.ReadUInt32();
					}
				}
				else
				{
					this.GKEJFEAKPAH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018AE RID: 6318
		private static readonly MessageParser<FinishChessRogueSubStoryCsReq> _parser = new MessageParser<FinishChessRogueSubStoryCsReq>(() => new FinishChessRogueSubStoryCsReq());

		// Token: 0x040018AF RID: 6319
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018B0 RID: 6320
		public const int GKEJFEAKPAHFieldNumber = 3;

		// Token: 0x040018B1 RID: 6321
		private uint gKEJFEAKPAH_;

		// Token: 0x040018B2 RID: 6322
		public const int LONLLBIHMIDFieldNumber = 6;

		// Token: 0x040018B3 RID: 6323
		private uint lONLLBIHMID_;

		// Token: 0x040018B4 RID: 6324
		public const int ChessRogueSubStoryIdFieldNumber = 14;

		// Token: 0x040018B5 RID: 6325
		private uint chessRogueSubStoryId_;
	}
}
