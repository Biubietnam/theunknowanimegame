using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200021D RID: 541
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGameAeonInfo : IMessage<ChessRogueGameAeonInfo>, IMessage, IEquatable<ChessRogueGameAeonInfo>, IDeepCloneable<ChessRogueGameAeonInfo>, IBufferMessage
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00046257 File Offset: 0x00044457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGameAeonInfo> Parser
		{
			get
			{
				return ChessRogueGameAeonInfo._parser;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0004625E File Offset: 0x0004445E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGameAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00046270 File Offset: 0x00044470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGameAeonInfo.Descriptor;
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00046277 File Offset: 0x00044477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameAeonInfo()
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00046280 File Offset: 0x00044480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameAeonInfo(ChessRogueGameAeonInfo other) : this()
		{
			this.hEHGLEKBGBK_ = ((other.hEHGLEKBGBK_ != null) ? other.hEHGLEKBGBK_.Clone() : null);
			this.gameAeonId_ = other.gameAeonId_;
			this.lAALOJHBPLO_ = other.lAALOJHBPLO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000462D8 File Offset: 0x000444D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameAeonInfo Clone()
		{
			return new ChessRogueGameAeonInfo(this);
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x000462E0 File Offset: 0x000444E0
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x000462E8 File Offset: 0x000444E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPEGOGNDPJJ HEHGLEKBGBK
		{
			get
			{
				return this.hEHGLEKBGBK_;
			}
			set
			{
				this.hEHGLEKBGBK_ = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000462F1 File Offset: 0x000444F1
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x000462F9 File Offset: 0x000444F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameAeonId
		{
			get
			{
				return this.gameAeonId_;
			}
			set
			{
				this.gameAeonId_ = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00046302 File Offset: 0x00044502
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0004630A File Offset: 0x0004450A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LAALOJHBPLO
		{
			get
			{
				return this.lAALOJHBPLO_;
			}
			set
			{
				this.lAALOJHBPLO_ = value;
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00046313 File Offset: 0x00044513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGameAeonInfo);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00046324 File Offset: 0x00044524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGameAeonInfo other)
		{
			return other != null && (other == this || (object.Equals(this.HEHGLEKBGBK, other.HEHGLEKBGBK) && this.GameAeonId == other.GameAeonId && this.LAALOJHBPLO == other.LAALOJHBPLO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00046384 File Offset: 0x00044584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hEHGLEKBGBK_ != null)
			{
				num ^= this.HEHGLEKBGBK.GetHashCode();
			}
			if (this.GameAeonId != 0U)
			{
				num ^= this.GameAeonId.GetHashCode();
			}
			if (this.LAALOJHBPLO != 0)
			{
				num ^= this.LAALOJHBPLO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000463F2 File Offset: 0x000445F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000463FA File Offset: 0x000445FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00046404 File Offset: 0x00044604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LAALOJHBPLO != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LAALOJHBPLO);
			}
			if (this.hEHGLEKBGBK_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.HEHGLEKBGBK);
			}
			if (this.GameAeonId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GameAeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00046478 File Offset: 0x00044678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hEHGLEKBGBK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HEHGLEKBGBK);
			}
			if (this.GameAeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAeonId);
			}
			if (this.LAALOJHBPLO != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LAALOJHBPLO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000464E8 File Offset: 0x000446E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGameAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hEHGLEKBGBK_ != null)
			{
				if (this.hEHGLEKBGBK_ == null)
				{
					this.HEHGLEKBGBK = new JPEGOGNDPJJ();
				}
				this.HEHGLEKBGBK.MergeFrom(other.HEHGLEKBGBK);
			}
			if (other.GameAeonId != 0U)
			{
				this.GameAeonId = other.GameAeonId;
			}
			if (other.LAALOJHBPLO != 0)
			{
				this.LAALOJHBPLO = other.LAALOJHBPLO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00046564 File Offset: 0x00044764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00046570 File Offset: 0x00044770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 42U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GameAeonId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.hEHGLEKBGBK_ == null)
						{
							this.HEHGLEKBGBK = new JPEGOGNDPJJ();
						}
						input.ReadMessage(this.HEHGLEKBGBK);
					}
				}
				else
				{
					this.LAALOJHBPLO = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000A53 RID: 2643
		private static readonly MessageParser<ChessRogueGameAeonInfo> _parser = new MessageParser<ChessRogueGameAeonInfo>(() => new ChessRogueGameAeonInfo());

		// Token: 0x04000A54 RID: 2644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A55 RID: 2645
		public const int HEHGLEKBGBKFieldNumber = 5;

		// Token: 0x04000A56 RID: 2646
		private JPEGOGNDPJJ hEHGLEKBGBK_;

		// Token: 0x04000A57 RID: 2647
		public const int GameAeonIdFieldNumber = 14;

		// Token: 0x04000A58 RID: 2648
		private uint gameAeonId_;

		// Token: 0x04000A59 RID: 2649
		public const int LAALOJHBPLOFieldNumber = 1;

		// Token: 0x04000A5A RID: 2650
		private int lAALOJHBPLO_;
	}
}
