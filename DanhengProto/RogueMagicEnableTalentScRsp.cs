using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC1 RID: 3777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnableTalentScRsp : IMessage<RogueMagicEnableTalentScRsp>, IMessage, IEquatable<RogueMagicEnableTalentScRsp>, IDeepCloneable<RogueMagicEnableTalentScRsp>, IBufferMessage
	{
		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x001C6BD3 File Offset: 0x001C4DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnableTalentScRsp> Parser
		{
			get
			{
				return RogueMagicEnableTalentScRsp._parser;
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600A8CD RID: 43213 RVA: 0x001C6BDA File Offset: 0x001C4DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnableTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x001C6BEC File Offset: 0x001C4DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnableTalentScRsp.Descriptor;
			}
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x001C6BF3 File Offset: 0x001C4DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentScRsp()
		{
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x001C6BFC File Offset: 0x001C4DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentScRsp(RogueMagicEnableTalentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueMagicTalentInfo_ = ((other.rogueMagicTalentInfo_ != null) ? other.rogueMagicTalentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x001C6C48 File Offset: 0x001C4E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentScRsp Clone()
		{
			return new RogueMagicEnableTalentScRsp(this);
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x001C6C50 File Offset: 0x001C4E50
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x001C6C58 File Offset: 0x001C4E58
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

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x001C6C61 File Offset: 0x001C4E61
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x001C6C69 File Offset: 0x001C4E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo RogueMagicTalentInfo
		{
			get
			{
				return this.rogueMagicTalentInfo_;
			}
			set
			{
				this.rogueMagicTalentInfo_ = value;
			}
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x001C6C72 File Offset: 0x001C4E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnableTalentScRsp);
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x001C6C80 File Offset: 0x001C4E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnableTalentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueMagicTalentInfo, other.RogueMagicTalentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x001C6CD0 File Offset: 0x001C4ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueMagicTalentInfo_ != null)
			{
				num ^= this.RogueMagicTalentInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x001C6D25 File Offset: 0x001C4F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x001C6D2D File Offset: 0x001C4F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x001C6D38 File Offset: 0x001C4F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueMagicTalentInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueMagicTalentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x001C6D94 File Offset: 0x001C4F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueMagicTalentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueMagicTalentInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x001C6DEC File Offset: 0x001C4FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnableTalentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueMagicTalentInfo_ != null)
			{
				if (this.rogueMagicTalentInfo_ == null)
				{
					this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
				}
				this.RogueMagicTalentInfo.MergeFrom(other.RogueMagicTalentInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x001C6E54 File Offset: 0x001C5054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x001C6E60 File Offset: 0x001C5060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueMagicTalentInfo_ == null)
						{
							this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
						}
						input.ReadMessage(this.RogueMagicTalentInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040044F7 RID: 17655
		private static readonly MessageParser<RogueMagicEnableTalentScRsp> _parser = new MessageParser<RogueMagicEnableTalentScRsp>(() => new RogueMagicEnableTalentScRsp());

		// Token: 0x040044F8 RID: 17656
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044F9 RID: 17657
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040044FA RID: 17658
		private uint retcode_;

		// Token: 0x040044FB RID: 17659
		public const int RogueMagicTalentInfoFieldNumber = 12;

		// Token: 0x040044FC RID: 17660
		private RogueMagicTalentInfo rogueMagicTalentInfo_;
	}
}
