using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200024F RID: 591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousDiceUpdateNotify : IMessage<ChessRogueNousDiceUpdateNotify>, IMessage, IEquatable<ChessRogueNousDiceUpdateNotify>, IDeepCloneable<ChessRogueNousDiceUpdateNotify>, IBufferMessage
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0004CDEB File Offset: 0x0004AFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousDiceUpdateNotify> Parser
		{
			get
			{
				return ChessRogueNousDiceUpdateNotify._parser;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0004CDF2 File Offset: 0x0004AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousDiceUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0004CE04 File Offset: 0x0004B004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousDiceUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0004CE0B File Offset: 0x0004B00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceUpdateNotify()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0004CE13 File Offset: 0x0004B013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceUpdateNotify(ChessRogueNousDiceUpdateNotify other) : this()
		{
			this.iDJMBBNLKDE_ = ((other.iDJMBBNLKDE_ != null) ? other.iDJMBBNLKDE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0004CE48 File Offset: 0x0004B048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceUpdateNotify Clone()
		{
			return new ChessRogueNousDiceUpdateNotify(this);
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0004CE50 File Offset: 0x0004B050
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0004CE58 File Offset: 0x0004B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiceInfo IDJMBBNLKDE
		{
			get
			{
				return this.iDJMBBNLKDE_;
			}
			set
			{
				this.iDJMBBNLKDE_ = value;
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0004CE61 File Offset: 0x0004B061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousDiceUpdateNotify);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0004CE6F File Offset: 0x0004B06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousDiceUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.IDJMBBNLKDE, other.IDJMBBNLKDE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0004CEA4 File Offset: 0x0004B0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iDJMBBNLKDE_ != null)
			{
				num ^= this.IDJMBBNLKDE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004CEE8 File Offset: 0x0004B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0004CEF1 File Offset: 0x0004B0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iDJMBBNLKDE_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.IDJMBBNLKDE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0004CF24 File Offset: 0x0004B124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iDJMBBNLKDE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IDJMBBNLKDE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004CF64 File Offset: 0x0004B164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousDiceUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iDJMBBNLKDE_ != null)
			{
				if (this.iDJMBBNLKDE_ == null)
				{
					this.IDJMBBNLKDE = new ChessRogueQueryDiceInfo();
				}
				this.IDJMBBNLKDE.MergeFrom(other.IDJMBBNLKDE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0004CFB8 File Offset: 0x0004B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0004CFC4 File Offset: 0x0004B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.iDJMBBNLKDE_ == null)
					{
						this.IDJMBBNLKDE = new ChessRogueQueryDiceInfo();
					}
					input.ReadMessage(this.IDJMBBNLKDE);
				}
			}
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly MessageParser<ChessRogueNousDiceUpdateNotify> _parser = new MessageParser<ChessRogueNousDiceUpdateNotify>(() => new ChessRogueNousDiceUpdateNotify());

		// Token: 0x04000B44 RID: 2884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B45 RID: 2885
		public const int IDJMBBNLKDEFieldNumber = 4;

		// Token: 0x04000B46 RID: 2886
		private ChessRogueQueryDiceInfo iDJMBBNLKDE_;
	}
}
