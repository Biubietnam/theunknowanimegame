using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001267 RID: 4711
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncChessRogueNousMainStoryScNotify : IMessage<SyncChessRogueNousMainStoryScNotify>, IMessage, IEquatable<SyncChessRogueNousMainStoryScNotify>, IDeepCloneable<SyncChessRogueNousMainStoryScNotify>, IBufferMessage
	{
		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600D251 RID: 53841 RVA: 0x0023224F File Offset: 0x0023044F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncChessRogueNousMainStoryScNotify> Parser
		{
			get
			{
				return SyncChessRogueNousMainStoryScNotify._parser;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600D252 RID: 53842 RVA: 0x00232256 File Offset: 0x00230456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncChessRogueNousMainStoryScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600D253 RID: 53843 RVA: 0x00232268 File Offset: 0x00230468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncChessRogueNousMainStoryScNotify.Descriptor;
			}
		}

		// Token: 0x0600D254 RID: 53844 RVA: 0x0023226F File Offset: 0x0023046F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousMainStoryScNotify()
		{
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x00232282 File Offset: 0x00230482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousMainStoryScNotify(SyncChessRogueNousMainStoryScNotify other) : this()
		{
			this.chessRogueMainStoryInfo_ = other.chessRogueMainStoryInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x002322AC File Offset: 0x002304AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousMainStoryScNotify Clone()
		{
			return new SyncChessRogueNousMainStoryScNotify(this);
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600D257 RID: 53847 RVA: 0x002322B4 File Offset: 0x002304B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueNousMainStoryInfo> ChessRogueMainStoryInfo
		{
			get
			{
				return this.chessRogueMainStoryInfo_;
			}
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x002322BC File Offset: 0x002304BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncChessRogueNousMainStoryScNotify);
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x002322CA File Offset: 0x002304CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncChessRogueNousMainStoryScNotify other)
		{
			return other != null && (other == this || (this.chessRogueMainStoryInfo_.Equals(other.chessRogueMainStoryInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x00232300 File Offset: 0x00230500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chessRogueMainStoryInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x00232334 File Offset: 0x00230534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x0023233C File Offset: 0x0023053C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x00232345 File Offset: 0x00230545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chessRogueMainStoryInfo_.WriteTo(ref output, SyncChessRogueNousMainStoryScNotify._repeated_chessRogueMainStoryInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x0023236C File Offset: 0x0023056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chessRogueMainStoryInfo_.CalculateSize(SyncChessRogueNousMainStoryScNotify._repeated_chessRogueMainStoryInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x002323A5 File Offset: 0x002305A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncChessRogueNousMainStoryScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.chessRogueMainStoryInfo_.Add(other.chessRogueMainStoryInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D260 RID: 53856 RVA: 0x002323D3 File Offset: 0x002305D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D261 RID: 53857 RVA: 0x002323DC File Offset: 0x002305DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.chessRogueMainStoryInfo_.AddEntriesFrom(ref input, SyncChessRogueNousMainStoryScNotify._repeated_chessRogueMainStoryInfo_codec);
				}
			}
		}

		// Token: 0x0400544E RID: 21582
		private static readonly MessageParser<SyncChessRogueNousMainStoryScNotify> _parser = new MessageParser<SyncChessRogueNousMainStoryScNotify>(() => new SyncChessRogueNousMainStoryScNotify());

		// Token: 0x0400544F RID: 21583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005450 RID: 21584
		public const int ChessRogueMainStoryInfoFieldNumber = 5;

		// Token: 0x04005451 RID: 21585
		private static readonly FieldCodec<ChessRogueNousMainStoryInfo> _repeated_chessRogueMainStoryInfo_codec = FieldCodec.ForMessage<ChessRogueNousMainStoryInfo>(42U, ChessRogueNousMainStoryInfo.Parser);

		// Token: 0x04005452 RID: 21586
		private readonly RepeatedField<ChessRogueNousMainStoryInfo> chessRogueMainStoryInfo_ = new RepeatedField<ChessRogueNousMainStoryInfo>();
	}
}
