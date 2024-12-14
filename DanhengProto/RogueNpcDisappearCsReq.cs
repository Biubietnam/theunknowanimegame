using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F5D RID: 3933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueNpcDisappearCsReq : IMessage<RogueNpcDisappearCsReq>, IMessage, IEquatable<RogueNpcDisappearCsReq>, IDeepCloneable<RogueNpcDisappearCsReq>, IBufferMessage
	{
		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x001D7270 File Offset: 0x001D5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueNpcDisappearCsReq> Parser
		{
			get
			{
				return RogueNpcDisappearCsReq._parser;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600AF53 RID: 44883 RVA: 0x001D7277 File Offset: 0x001D5477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueNpcDisappearCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x001D7289 File Offset: 0x001D5489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueNpcDisappearCsReq.Descriptor;
			}
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x001D7290 File Offset: 0x001D5490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearCsReq()
		{
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x001D7298 File Offset: 0x001D5498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearCsReq(RogueNpcDisappearCsReq other) : this()
		{
			this.disappearNpcEntityId_ = other.disappearNpcEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x001D72BD File Offset: 0x001D54BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearCsReq Clone()
		{
			return new RogueNpcDisappearCsReq(this);
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x001D72C5 File Offset: 0x001D54C5
		// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x001D72CD File Offset: 0x001D54CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DisappearNpcEntityId
		{
			get
			{
				return this.disappearNpcEntityId_;
			}
			set
			{
				this.disappearNpcEntityId_ = value;
			}
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x001D72D6 File Offset: 0x001D54D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueNpcDisappearCsReq);
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x001D72E4 File Offset: 0x001D54E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueNpcDisappearCsReq other)
		{
			return other != null && (other == this || (this.DisappearNpcEntityId == other.DisappearNpcEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x001D7314 File Offset: 0x001D5514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisappearNpcEntityId != 0U)
			{
				num ^= this.DisappearNpcEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x001D7353 File Offset: 0x001D5553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x001D735B File Offset: 0x001D555B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF5F RID: 44895 RVA: 0x001D7364 File Offset: 0x001D5564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisappearNpcEntityId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DisappearNpcEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x001D7398 File Offset: 0x001D5598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisappearNpcEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DisappearNpcEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x001D73D6 File Offset: 0x001D55D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueNpcDisappearCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisappearNpcEntityId != 0U)
			{
				this.DisappearNpcEntityId = other.DisappearNpcEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x001D7407 File Offset: 0x001D5607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x001D7410 File Offset: 0x001D5610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DisappearNpcEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004754 RID: 18260
		private static readonly MessageParser<RogueNpcDisappearCsReq> _parser = new MessageParser<RogueNpcDisappearCsReq>(() => new RogueNpcDisappearCsReq());

		// Token: 0x04004755 RID: 18261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004756 RID: 18262
		public const int DisappearNpcEntityIdFieldNumber = 3;

		// Token: 0x04004757 RID: 18263
		private uint disappearNpcEntityId_;
	}
}
