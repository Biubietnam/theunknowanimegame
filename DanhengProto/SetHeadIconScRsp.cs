using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001107 RID: 4359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetHeadIconScRsp : IMessage<SetHeadIconScRsp>, IMessage, IEquatable<SetHeadIconScRsp>, IDeepCloneable<SetHeadIconScRsp>, IBufferMessage
	{
		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600C25E RID: 49758 RVA: 0x0020A27C File Offset: 0x0020847C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetHeadIconScRsp> Parser
		{
			get
			{
				return SetHeadIconScRsp._parser;
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600C25F RID: 49759 RVA: 0x0020A283 File Offset: 0x00208483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetHeadIconScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600C260 RID: 49760 RVA: 0x0020A295 File Offset: 0x00208495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetHeadIconScRsp.Descriptor;
			}
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x0020A29C File Offset: 0x0020849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconScRsp()
		{
		}

		// Token: 0x0600C262 RID: 49762 RVA: 0x0020A2A4 File Offset: 0x002084A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconScRsp(SetHeadIconScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.currentHeadIconId_ = other.currentHeadIconId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x0020A2D5 File Offset: 0x002084D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconScRsp Clone()
		{
			return new SetHeadIconScRsp(this);
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600C264 RID: 49764 RVA: 0x0020A2DD File Offset: 0x002084DD
		// (set) Token: 0x0600C265 RID: 49765 RVA: 0x0020A2E5 File Offset: 0x002084E5
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

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x0020A2EE File Offset: 0x002084EE
		// (set) Token: 0x0600C267 RID: 49767 RVA: 0x0020A2F6 File Offset: 0x002084F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrentHeadIconId
		{
			get
			{
				return this.currentHeadIconId_;
			}
			set
			{
				this.currentHeadIconId_ = value;
			}
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x0020A2FF File Offset: 0x002084FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetHeadIconScRsp);
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x0020A30D File Offset: 0x0020850D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetHeadIconScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CurrentHeadIconId == other.CurrentHeadIconId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x0020A34C File Offset: 0x0020854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurrentHeadIconId != 0U)
			{
				num ^= this.CurrentHeadIconId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x0020A3A4 File Offset: 0x002085A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x0020A3AC File Offset: 0x002085AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x0020A3B8 File Offset: 0x002085B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurrentHeadIconId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurrentHeadIconId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x0020A414 File Offset: 0x00208614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurrentHeadIconId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentHeadIconId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x0020A46C File Offset: 0x0020866C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetHeadIconScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurrentHeadIconId != 0U)
			{
				this.CurrentHeadIconId = other.CurrentHeadIconId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x0020A4BC File Offset: 0x002086BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x0020A4C8 File Offset: 0x002086C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurrentHeadIconId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004EA3 RID: 20131
		private static readonly MessageParser<SetHeadIconScRsp> _parser = new MessageParser<SetHeadIconScRsp>(() => new SetHeadIconScRsp());

		// Token: 0x04004EA4 RID: 20132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA5 RID: 20133
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004EA6 RID: 20134
		private uint retcode_;

		// Token: 0x04004EA7 RID: 20135
		public const int CurrentHeadIconIdFieldNumber = 9;

		// Token: 0x04004EA8 RID: 20136
		private uint currentHeadIconId_;
	}
}
