using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B4D RID: 2893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGiveUpCurContentCsReq : IMessage<MonopolyGiveUpCurContentCsReq>, IMessage, IEquatable<MonopolyGiveUpCurContentCsReq>, IDeepCloneable<MonopolyGiveUpCurContentCsReq>, IBufferMessage
	{
		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x00152238 File Offset: 0x00150438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGiveUpCurContentCsReq> Parser
		{
			get
			{
				return MonopolyGiveUpCurContentCsReq._parser;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x06008011 RID: 32785 RVA: 0x0015223F File Offset: 0x0015043F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGiveUpCurContentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x00152251 File Offset: 0x00150451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGiveUpCurContentCsReq.Descriptor;
			}
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x00152258 File Offset: 0x00150458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentCsReq()
		{
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x00152260 File Offset: 0x00150460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentCsReq(MonopolyGiveUpCurContentCsReq other) : this()
		{
			this.contentId_ = other.contentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00152285 File Offset: 0x00150485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGiveUpCurContentCsReq Clone()
		{
			return new MonopolyGiveUpCurContentCsReq(this);
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x06008016 RID: 32790 RVA: 0x0015228D File Offset: 0x0015048D
		// (set) Token: 0x06008017 RID: 32791 RVA: 0x00152295 File Offset: 0x00150495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x0015229E File Offset: 0x0015049E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGiveUpCurContentCsReq);
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x001522AC File Offset: 0x001504AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGiveUpCurContentCsReq other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x001522DC File Offset: 0x001504DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x0015231B File Offset: 0x0015051B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x00152323 File Offset: 0x00150523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x0015232C File Offset: 0x0015052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00152360 File Offset: 0x00150560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x0015239E File Offset: 0x0015059E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGiveUpCurContentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x001523CF File Offset: 0x001505CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x001523D8 File Offset: 0x001505D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003101 RID: 12545
		private static readonly MessageParser<MonopolyGiveUpCurContentCsReq> _parser = new MessageParser<MonopolyGiveUpCurContentCsReq>(() => new MonopolyGiveUpCurContentCsReq());

		// Token: 0x04003102 RID: 12546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003103 RID: 12547
		public const int ContentIdFieldNumber = 5;

		// Token: 0x04003104 RID: 12548
		private uint contentId_;
	}
}
