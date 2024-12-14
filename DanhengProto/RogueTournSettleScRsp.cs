using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101B RID: 4123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournSettleScRsp : IMessage<RogueTournSettleScRsp>, IMessage, IEquatable<RogueTournSettleScRsp>, IDeepCloneable<RogueTournSettleScRsp>, IBufferMessage
	{
		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x001EBC73 File Offset: 0x001E9E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournSettleScRsp> Parser
		{
			get
			{
				return RogueTournSettleScRsp._parser;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600B751 RID: 46929 RVA: 0x001EBC7A File Offset: 0x001E9E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournSettleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600B752 RID: 46930 RVA: 0x001EBC8C File Offset: 0x001E9E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournSettleScRsp.Descriptor;
			}
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x001EBC93 File Offset: 0x001E9E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleScRsp()
		{
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x001EBC9C File Offset: 0x001E9E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleScRsp(RogueTournSettleScRsp other) : this()
		{
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x001EBD04 File Offset: 0x001E9F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSettleScRsp Clone()
		{
			return new RogueTournSettleScRsp(this);
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x001EBD0C File Offset: 0x001E9F0C
		// (set) Token: 0x0600B757 RID: 46935 RVA: 0x001EBD14 File Offset: 0x001E9F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo TournFinishInfo
		{
			get
			{
				return this.tournFinishInfo_;
			}
			set
			{
				this.tournFinishInfo_ = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600B758 RID: 46936 RVA: 0x001EBD1D File Offset: 0x001E9F1D
		// (set) Token: 0x0600B759 RID: 46937 RVA: 0x001EBD25 File Offset: 0x001E9F25
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

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600B75A RID: 46938 RVA: 0x001EBD2E File Offset: 0x001E9F2E
		// (set) Token: 0x0600B75B RID: 46939 RVA: 0x001EBD36 File Offset: 0x001E9F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x001EBD3F File Offset: 0x001E9F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournSettleScRsp);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x001EBD50 File Offset: 0x001E9F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournSettleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.TournFinishInfo, other.TournFinishInfo) && this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x001EBDB4 File Offset: 0x001E9FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x001EBE1F File Offset: 0x001EA01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x001EBE27 File Offset: 0x001EA027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x001EBE30 File Offset: 0x001EA030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x001EBEA8 File Offset: 0x001EA0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x001EBF18 File Offset: 0x001EA118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournSettleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueTournFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x001EBFAC File Offset: 0x001EA1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x001EBFB8 File Offset: 0x001EA1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 26U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueTournCurSceneInfo_ == null)
							{
								this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
							}
							input.ReadMessage(this.RogueTournCurSceneInfo);
						}
					}
					else
					{
						if (this.tournFinishInfo_ == null)
						{
							this.TournFinishInfo = new RogueTournFinishInfo();
						}
						input.ReadMessage(this.TournFinishInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004A42 RID: 19010
		private static readonly MessageParser<RogueTournSettleScRsp> _parser = new MessageParser<RogueTournSettleScRsp>(() => new RogueTournSettleScRsp());

		// Token: 0x04004A43 RID: 19011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A44 RID: 19012
		public const int TournFinishInfoFieldNumber = 3;

		// Token: 0x04004A45 RID: 19013
		private RogueTournFinishInfo tournFinishInfo_;

		// Token: 0x04004A46 RID: 19014
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004A47 RID: 19015
		private uint retcode_;

		// Token: 0x04004A48 RID: 19016
		public const int RogueTournCurSceneInfoFieldNumber = 13;

		// Token: 0x04004A49 RID: 19017
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;
	}
}
