using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F3 RID: 4339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetFriendMarkScRsp : IMessage<SetFriendMarkScRsp>, IMessage, IEquatable<SetFriendMarkScRsp>, IDeepCloneable<SetFriendMarkScRsp>, IBufferMessage
	{
		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600C173 RID: 49523 RVA: 0x00207FB1 File Offset: 0x002061B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetFriendMarkScRsp> Parser
		{
			get
			{
				return SetFriendMarkScRsp._parser;
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600C174 RID: 49524 RVA: 0x00207FB8 File Offset: 0x002061B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetFriendMarkScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600C175 RID: 49525 RVA: 0x00207FCA File Offset: 0x002061CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFriendMarkScRsp.Descriptor;
			}
		}

		// Token: 0x0600C176 RID: 49526 RVA: 0x00207FD1 File Offset: 0x002061D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkScRsp()
		{
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x00207FD9 File Offset: 0x002061D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkScRsp(SetFriendMarkScRsp other) : this()
		{
			this.uid_ = other.uid_;
			this.retcode_ = other.retcode_;
			this.lBIOKLPIACM_ = other.lBIOKLPIACM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C178 RID: 49528 RVA: 0x00208016 File Offset: 0x00206216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendMarkScRsp Clone()
		{
			return new SetFriendMarkScRsp(this);
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600C179 RID: 49529 RVA: 0x0020801E File Offset: 0x0020621E
		// (set) Token: 0x0600C17A RID: 49530 RVA: 0x00208026 File Offset: 0x00206226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600C17B RID: 49531 RVA: 0x0020802F File Offset: 0x0020622F
		// (set) Token: 0x0600C17C RID: 49532 RVA: 0x00208037 File Offset: 0x00206237
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

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600C17D RID: 49533 RVA: 0x00208040 File Offset: 0x00206240
		// (set) Token: 0x0600C17E RID: 49534 RVA: 0x00208048 File Offset: 0x00206248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LBIOKLPIACM
		{
			get
			{
				return this.lBIOKLPIACM_;
			}
			set
			{
				this.lBIOKLPIACM_ = value;
			}
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x00208051 File Offset: 0x00206251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFriendMarkScRsp);
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x00208060 File Offset: 0x00206260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFriendMarkScRsp other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.Retcode == other.Retcode && this.LBIOKLPIACM == other.LBIOKLPIACM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x002080BC File Offset: 0x002062BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LBIOKLPIACM)
			{
				num ^= this.LBIOKLPIACM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C182 RID: 49538 RVA: 0x0020812D File Offset: 0x0020632D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x00208135 File Offset: 0x00206335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C184 RID: 49540 RVA: 0x00208140 File Offset: 0x00206340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LBIOKLPIACM)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.LBIOKLPIACM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x002081B4 File Offset: 0x002063B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LBIOKLPIACM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x00208218 File Offset: 0x00206418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFriendMarkScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LBIOKLPIACM)
			{
				this.LBIOKLPIACM = other.LBIOKLPIACM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x0020827C File Offset: 0x0020647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x00208288 File Offset: 0x00206488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LBIOKLPIACM = input.ReadBool();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E56 RID: 20054
		private static readonly MessageParser<SetFriendMarkScRsp> _parser = new MessageParser<SetFriendMarkScRsp>(() => new SetFriendMarkScRsp());

		// Token: 0x04004E57 RID: 20055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E58 RID: 20056
		public const int UidFieldNumber = 1;

		// Token: 0x04004E59 RID: 20057
		private uint uid_;

		// Token: 0x04004E5A RID: 20058
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004E5B RID: 20059
		private uint retcode_;

		// Token: 0x04004E5C RID: 20060
		public const int LBIOKLPIACMFieldNumber = 15;

		// Token: 0x04004E5D RID: 20061
		private bool lBIOKLPIACM_;
	}
}
