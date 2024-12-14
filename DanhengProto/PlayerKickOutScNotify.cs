using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC1 RID: 3265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerKickOutScNotify : IMessage<PlayerKickOutScNotify>, IMessage, IEquatable<PlayerKickOutScNotify>, IDeepCloneable<PlayerKickOutScNotify>, IBufferMessage
	{
		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x00180DF7 File Offset: 0x0017EFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerKickOutScNotify> Parser
		{
			get
			{
				return PlayerKickOutScNotify._parser;
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x06009163 RID: 37219 RVA: 0x00180DFE File Offset: 0x0017EFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerKickOutScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x00180E10 File Offset: 0x0017F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerKickOutScNotify.Descriptor;
			}
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x00180E17 File Offset: 0x0017F017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerKickOutScNotify()
		{
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x00180E20 File Offset: 0x0017F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerKickOutScNotify(PlayerKickOutScNotify other) : this()
		{
			this.blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
			this.kickType_ = other.kickType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x00180E6C File Offset: 0x0017F06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerKickOutScNotify Clone()
		{
			return new PlayerKickOutScNotify(this);
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x06009168 RID: 37224 RVA: 0x00180E74 File Offset: 0x0017F074
		// (set) Token: 0x06009169 RID: 37225 RVA: 0x00180E7C File Offset: 0x0017F07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackInfo BlackInfo
		{
			get
			{
				return this.blackInfo_;
			}
			set
			{
				this.blackInfo_ = value;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x00180E85 File Offset: 0x0017F085
		// (set) Token: 0x0600916B RID: 37227 RVA: 0x00180E8D File Offset: 0x0017F08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickType KickType
		{
			get
			{
				return this.kickType_;
			}
			set
			{
				this.kickType_ = value;
			}
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x00180E96 File Offset: 0x0017F096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerKickOutScNotify);
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x00180EA4 File Offset: 0x0017F0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerKickOutScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BlackInfo, other.BlackInfo) && this.KickType == other.KickType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x00180EF4 File Offset: 0x0017F0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.blackInfo_ != null)
			{
				num ^= this.BlackInfo.GetHashCode();
			}
			if (this.KickType != KickType.KickSqueezed)
			{
				num ^= this.KickType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x00180F4F File Offset: 0x0017F14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x00180F57 File Offset: 0x0017F157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x00180F60 File Offset: 0x0017F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.blackInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BlackInfo);
			}
			if (this.KickType != KickType.KickSqueezed)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.KickType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x00180FBC File Offset: 0x0017F1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.blackInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackInfo);
			}
			if (this.KickType != KickType.KickSqueezed)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KickType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x00181014 File Offset: 0x0017F214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerKickOutScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.blackInfo_ != null)
			{
				if (this.blackInfo_ == null)
				{
					this.BlackInfo = new BlackInfo();
				}
				this.BlackInfo.MergeFrom(other.BlackInfo);
			}
			if (other.KickType != KickType.KickSqueezed)
			{
				this.KickType = other.KickType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009174 RID: 37236 RVA: 0x0018107C File Offset: 0x0017F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009175 RID: 37237 RVA: 0x00181088 File Offset: 0x0017F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KickType = (KickType)input.ReadEnum();
					}
				}
				else
				{
					if (this.blackInfo_ == null)
					{
						this.BlackInfo = new BlackInfo();
					}
					input.ReadMessage(this.BlackInfo);
				}
			}
		}

		// Token: 0x04003802 RID: 14338
		private static readonly MessageParser<PlayerKickOutScNotify> _parser = new MessageParser<PlayerKickOutScNotify>(() => new PlayerKickOutScNotify());

		// Token: 0x04003803 RID: 14339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003804 RID: 14340
		public const int BlackInfoFieldNumber = 12;

		// Token: 0x04003805 RID: 14341
		private BlackInfo blackInfo_;

		// Token: 0x04003806 RID: 14342
		public const int KickTypeFieldNumber = 14;

		// Token: 0x04003807 RID: 14343
		private KickType kickType_;
	}
}
