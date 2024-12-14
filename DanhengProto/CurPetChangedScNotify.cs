using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033F RID: 831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CurPetChangedScNotify : IMessage<CurPetChangedScNotify>, IMessage, IEquatable<CurPetChangedScNotify>, IDeepCloneable<CurPetChangedScNotify>, IBufferMessage
	{
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x00069000 File Offset: 0x00067200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CurPetChangedScNotify> Parser
		{
			get
			{
				return CurPetChangedScNotify._parser;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00069007 File Offset: 0x00067207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CurPetChangedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00069019 File Offset: 0x00067219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurPetChangedScNotify.Descriptor;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00069020 File Offset: 0x00067220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurPetChangedScNotify()
		{
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00069028 File Offset: 0x00067228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurPetChangedScNotify(CurPetChangedScNotify other) : this()
		{
			this.curPetId_ = other.curPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0006904D File Offset: 0x0006724D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurPetChangedScNotify Clone()
		{
			return new CurPetChangedScNotify(this);
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x00069055 File Offset: 0x00067255
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x0006905D File Offset: 0x0006725D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurPetId
		{
			get
			{
				return this.curPetId_;
			}
			set
			{
				this.curPetId_ = value;
			}
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00069066 File Offset: 0x00067266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurPetChangedScNotify);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00069074 File Offset: 0x00067274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CurPetChangedScNotify other)
		{
			return other != null && (other == this || (this.CurPetId == other.CurPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000690A4 File Offset: 0x000672A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurPetId != 0U)
			{
				num ^= this.CurPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000690E3 File Offset: 0x000672E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000690EB File Offset: 0x000672EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000690F4 File Offset: 0x000672F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurPetId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurPetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00069128 File Offset: 0x00067328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00069166 File Offset: 0x00067366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CurPetChangedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurPetId != 0U)
			{
				this.CurPetId = other.CurPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00069197 File Offset: 0x00067397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000691A0 File Offset: 0x000673A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurPetId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F28 RID: 3880
		private static readonly MessageParser<CurPetChangedScNotify> _parser = new MessageParser<CurPetChangedScNotify>(() => new CurPetChangedScNotify());

		// Token: 0x04000F29 RID: 3881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F2A RID: 3882
		public const int CurPetIdFieldNumber = 9;

		// Token: 0x04000F2B RID: 3883
		private uint curPetId_;
	}
}
