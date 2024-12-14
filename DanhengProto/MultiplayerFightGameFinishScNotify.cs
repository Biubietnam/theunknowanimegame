using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA5 RID: 2981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGameFinishScNotify : IMessage<MultiplayerFightGameFinishScNotify>, IMessage, IEquatable<MultiplayerFightGameFinishScNotify>, IDeepCloneable<MultiplayerFightGameFinishScNotify>, IBufferMessage
	{
		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x060083E5 RID: 33765 RVA: 0x0015C4C9 File Offset: 0x0015A6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGameFinishScNotify> Parser
		{
			get
			{
				return MultiplayerFightGameFinishScNotify._parser;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x060083E6 RID: 33766 RVA: 0x0015C4D0 File Offset: 0x0015A6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGameFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x060083E7 RID: 33767 RVA: 0x0015C4E2 File Offset: 0x0015A6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGameFinishScNotify.Descriptor;
			}
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x0015C4E9 File Offset: 0x0015A6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameFinishScNotify()
		{
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x0015C4F1 File Offset: 0x0015A6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameFinishScNotify(MultiplayerFightGameFinishScNotify other) : this()
		{
			this.bANNAKDNBFA_ = ((other.bANNAKDNBFA_ != null) ? other.bANNAKDNBFA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x0015C526 File Offset: 0x0015A726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameFinishScNotify Clone()
		{
			return new MultiplayerFightGameFinishScNotify(this);
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x0015C52E File Offset: 0x0015A72E
		// (set) Token: 0x060083EC RID: 33772 RVA: 0x0015C536 File Offset: 0x0015A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE BANNAKDNBFA
		{
			get
			{
				return this.bANNAKDNBFA_;
			}
			set
			{
				this.bANNAKDNBFA_ = value;
			}
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x0015C53F File Offset: 0x0015A73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGameFinishScNotify);
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x0015C54D File Offset: 0x0015A74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGameFinishScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BANNAKDNBFA, other.BANNAKDNBFA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x0015C580 File Offset: 0x0015A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bANNAKDNBFA_ != null)
			{
				num ^= this.BANNAKDNBFA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x0015C5BC File Offset: 0x0015A7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083F1 RID: 33777 RVA: 0x0015C5C4 File Offset: 0x0015A7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x0015C5CD File Offset: 0x0015A7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bANNAKDNBFA_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x0015C600 File Offset: 0x0015A800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bANNAKDNBFA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083F4 RID: 33780 RVA: 0x0015C640 File Offset: 0x0015A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGameFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bANNAKDNBFA_ != null)
			{
				if (this.bANNAKDNBFA_ == null)
				{
					this.BANNAKDNBFA = new EDDPABIGHBE();
				}
				this.BANNAKDNBFA.MergeFrom(other.BANNAKDNBFA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083F5 RID: 33781 RVA: 0x0015C694 File Offset: 0x0015A894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x0015C6A0 File Offset: 0x0015A8A0
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
					if (this.bANNAKDNBFA_ == null)
					{
						this.BANNAKDNBFA = new EDDPABIGHBE();
					}
					input.ReadMessage(this.BANNAKDNBFA);
				}
			}
		}

		// Token: 0x0400328A RID: 12938
		private static readonly MessageParser<MultiplayerFightGameFinishScNotify> _parser = new MessageParser<MultiplayerFightGameFinishScNotify>(() => new MultiplayerFightGameFinishScNotify());

		// Token: 0x0400328B RID: 12939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400328C RID: 12940
		public const int BANNAKDNBFAFieldNumber = 5;

		// Token: 0x0400328D RID: 12941
		private EDDPABIGHBE bANNAKDNBFA_;
	}
}
