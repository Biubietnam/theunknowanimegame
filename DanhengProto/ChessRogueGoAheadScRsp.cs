using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200022D RID: 557
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGoAheadScRsp : IMessage<ChessRogueGoAheadScRsp>, IMessage, IEquatable<ChessRogueGoAheadScRsp>, IDeepCloneable<ChessRogueGoAheadScRsp>, IBufferMessage
	{
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0004911C File Offset: 0x0004731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGoAheadScRsp> Parser
		{
			get
			{
				return ChessRogueGoAheadScRsp._parser;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00049123 File Offset: 0x00047323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGoAheadScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00049135 File Offset: 0x00047335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGoAheadScRsp.Descriptor;
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0004913C File Offset: 0x0004733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadScRsp()
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00049144 File Offset: 0x00047344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadScRsp(ChessRogueGoAheadScRsp other) : this()
		{
			this.cellId_ = other.cellId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00049175 File Offset: 0x00047375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGoAheadScRsp Clone()
		{
			return new ChessRogueGoAheadScRsp(this);
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0004917D File Offset: 0x0004737D
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x00049185 File Offset: 0x00047385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0004918E File Offset: 0x0004738E
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00049196 File Offset: 0x00047396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0004919F File Offset: 0x0004739F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGoAheadScRsp);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000491AD File Offset: 0x000473AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGoAheadScRsp other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000491EC File Offset: 0x000473EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00049244 File Offset: 0x00047444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0004924C File Offset: 0x0004744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00049258 File Offset: 0x00047458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CellId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000492B4 File Offset: 0x000474B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0004930C File Offset: 0x0004750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGoAheadScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0004935C File Offset: 0x0004755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00049368 File Offset: 0x00047568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000AB2 RID: 2738
		private static readonly MessageParser<ChessRogueGoAheadScRsp> _parser = new MessageParser<ChessRogueGoAheadScRsp>(() => new ChessRogueGoAheadScRsp());

		// Token: 0x04000AB3 RID: 2739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AB4 RID: 2740
		public const int CellIdFieldNumber = 9;

		// Token: 0x04000AB5 RID: 2741
		private uint cellId_;

		// Token: 0x04000AB6 RID: 2742
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000AB7 RID: 2743
		private uint retcode_;
	}
}
