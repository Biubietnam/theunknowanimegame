using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200126B RID: 4715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncChessRogueNousValueScNotify : IMessage<SyncChessRogueNousValueScNotify>, IMessage, IEquatable<SyncChessRogueNousValueScNotify>, IDeepCloneable<SyncChessRogueNousValueScNotify>, IBufferMessage
	{
		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600D27A RID: 53882 RVA: 0x0023275B File Offset: 0x0023095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncChessRogueNousValueScNotify> Parser
		{
			get
			{
				return SyncChessRogueNousValueScNotify._parser;
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600D27B RID: 53883 RVA: 0x00232762 File Offset: 0x00230962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncChessRogueNousValueScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600D27C RID: 53884 RVA: 0x00232774 File Offset: 0x00230974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncChessRogueNousValueScNotify.Descriptor;
			}
		}

		// Token: 0x0600D27D RID: 53885 RVA: 0x0023277B File Offset: 0x0023097B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousValueScNotify()
		{
		}

		// Token: 0x0600D27E RID: 53886 RVA: 0x00232783 File Offset: 0x00230983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousValueScNotify(SyncChessRogueNousValueScNotify other) : this()
		{
			this.nousValueInfo_ = ((other.nousValueInfo_ != null) ? other.nousValueInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D27F RID: 53887 RVA: 0x002327B8 File Offset: 0x002309B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousValueScNotify Clone()
		{
			return new SyncChessRogueNousValueScNotify(this);
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600D280 RID: 53888 RVA: 0x002327C0 File Offset: 0x002309C0
		// (set) Token: 0x0600D281 RID: 53889 RVA: 0x002327C8 File Offset: 0x002309C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousValueInfo NousValueInfo
		{
			get
			{
				return this.nousValueInfo_;
			}
			set
			{
				this.nousValueInfo_ = value;
			}
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x002327D1 File Offset: 0x002309D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncChessRogueNousValueScNotify);
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x002327DF File Offset: 0x002309DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncChessRogueNousValueScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.NousValueInfo, other.NousValueInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x00232814 File Offset: 0x00230A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.nousValueInfo_ != null)
			{
				num ^= this.NousValueInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00232850 File Offset: 0x00230A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00232858 File Offset: 0x00230A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x00232861 File Offset: 0x00230A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nousValueInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NousValueInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x00232894 File Offset: 0x00230A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.nousValueInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NousValueInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x002328D4 File Offset: 0x00230AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncChessRogueNousValueScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.nousValueInfo_ != null)
			{
				if (this.nousValueInfo_ == null)
				{
					this.NousValueInfo = new ChessRogueNousValueInfo();
				}
				this.NousValueInfo.MergeFrom(other.NousValueInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x00232928 File Offset: 0x00230B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x00232934 File Offset: 0x00230B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.nousValueInfo_ == null)
					{
						this.NousValueInfo = new ChessRogueNousValueInfo();
					}
					input.ReadMessage(this.NousValueInfo);
				}
			}
		}

		// Token: 0x04005459 RID: 21593
		private static readonly MessageParser<SyncChessRogueNousValueScNotify> _parser = new MessageParser<SyncChessRogueNousValueScNotify>(() => new SyncChessRogueNousValueScNotify());

		// Token: 0x0400545A RID: 21594
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400545B RID: 21595
		public const int NousValueInfoFieldNumber = 3;

		// Token: 0x0400545C RID: 21596
		private ChessRogueNousValueInfo nousValueInfo_;
	}
}
