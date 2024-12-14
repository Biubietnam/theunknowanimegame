using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E77 RID: 3703
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueEndlessActivityBattleEndScNotify : IMessage<RogueEndlessActivityBattleEndScNotify>, IMessage, IEquatable<RogueEndlessActivityBattleEndScNotify>, IDeepCloneable<RogueEndlessActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600A533 RID: 42291 RVA: 0x001BC037 File Offset: 0x001BA237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueEndlessActivityBattleEndScNotify> Parser
		{
			get
			{
				return RogueEndlessActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x001BC03E File Offset: 0x001BA23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueEndlessActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600A535 RID: 42293 RVA: 0x001BC050 File Offset: 0x001BA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueEndlessActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x001BC057 File Offset: 0x001BA257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessActivityBattleEndScNotify()
		{
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x001BC05F File Offset: 0x001BA25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessActivityBattleEndScNotify(RogueEndlessActivityBattleEndScNotify other) : this()
		{
			this.hCMHGKIJKFI_ = ((other.hCMHGKIJKFI_ != null) ? other.hCMHGKIJKFI_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x001BC094 File Offset: 0x001BA294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessActivityBattleEndScNotify Clone()
		{
			return new RogueEndlessActivityBattleEndScNotify(this);
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600A539 RID: 42297 RVA: 0x001BC09C File Offset: 0x001BA29C
		// (set) Token: 0x0600A53A RID: 42298 RVA: 0x001BC0A4 File Offset: 0x001BA2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo HCMHGKIJKFI
		{
			get
			{
				return this.hCMHGKIJKFI_;
			}
			set
			{
				this.hCMHGKIJKFI_ = value;
			}
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x001BC0AD File Offset: 0x001BA2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueEndlessActivityBattleEndScNotify);
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x001BC0BB File Offset: 0x001BA2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueEndlessActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HCMHGKIJKFI, other.HCMHGKIJKFI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x001BC0F0 File Offset: 0x001BA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hCMHGKIJKFI_ != null)
			{
				num ^= this.HCMHGKIJKFI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x001BC12C File Offset: 0x001BA32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x001BC134 File Offset: 0x001BA334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x001BC13D File Offset: 0x001BA33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hCMHGKIJKFI_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HCMHGKIJKFI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x001BC170 File Offset: 0x001BA370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hCMHGKIJKFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HCMHGKIJKFI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x001BC1B0 File Offset: 0x001BA3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueEndlessActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hCMHGKIJKFI_ != null)
			{
				if (this.hCMHGKIJKFI_ == null)
				{
					this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
				}
				this.HCMHGKIJKFI.MergeFrom(other.HCMHGKIJKFI);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x001BC204 File Offset: 0x001BA404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x001BC210 File Offset: 0x001BA410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.hCMHGKIJKFI_ == null)
					{
						this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
					}
					input.ReadMessage(this.HCMHGKIJKFI);
				}
			}
		}

		// Token: 0x04004379 RID: 17273
		private static readonly MessageParser<RogueEndlessActivityBattleEndScNotify> _parser = new MessageParser<RogueEndlessActivityBattleEndScNotify>(() => new RogueEndlessActivityBattleEndScNotify());

		// Token: 0x0400437A RID: 17274
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400437B RID: 17275
		public const int HCMHGKIJKFIFieldNumber = 7;

		// Token: 0x0400437C RID: 17276
		private RogueEndlessLayerInfo hCMHGKIJKFI_;
	}
}
