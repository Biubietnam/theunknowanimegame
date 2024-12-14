using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C5 RID: 2245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSelectSkillScRsp : IMessage<HeliobusSelectSkillScRsp>, IMessage, IEquatable<HeliobusSelectSkillScRsp>, IDeepCloneable<HeliobusSelectSkillScRsp>, IBufferMessage
	{
		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x0010C0FC File Offset: 0x0010A2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSelectSkillScRsp> Parser
		{
			get
			{
				return HeliobusSelectSkillScRsp._parser;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x0010C103 File Offset: 0x0010A303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSelectSkillScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x0010C115 File Offset: 0x0010A315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSelectSkillScRsp.Descriptor;
			}
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x0010C11C File Offset: 0x0010A31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillScRsp()
		{
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x0010C124 File Offset: 0x0010A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillScRsp(HeliobusSelectSkillScRsp other) : this()
		{
			this.skillId_ = other.skillId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x0010C155 File Offset: 0x0010A355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillScRsp Clone()
		{
			return new HeliobusSelectSkillScRsp(this);
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x0600641C RID: 25628 RVA: 0x0010C15D File Offset: 0x0010A35D
		// (set) Token: 0x0600641D RID: 25629 RVA: 0x0010C165 File Offset: 0x0010A365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x0600641E RID: 25630 RVA: 0x0010C16E File Offset: 0x0010A36E
		// (set) Token: 0x0600641F RID: 25631 RVA: 0x0010C176 File Offset: 0x0010A376
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

		// Token: 0x06006420 RID: 25632 RVA: 0x0010C17F File Offset: 0x0010A37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSelectSkillScRsp);
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x0010C18D File Offset: 0x0010A38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSelectSkillScRsp other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x0010C1CC File Offset: 0x0010A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x0010C224 File Offset: 0x0010A424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x0010C22C File Offset: 0x0010A42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x0010C238 File Offset: 0x0010A438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x0010C294 File Offset: 0x0010A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x0010C2EC File Offset: 0x0010A4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSelectSkillScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x0010C33C File Offset: 0x0010A53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x0010C348 File Offset: 0x0010A548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002693 RID: 9875
		private static readonly MessageParser<HeliobusSelectSkillScRsp> _parser = new MessageParser<HeliobusSelectSkillScRsp>(() => new HeliobusSelectSkillScRsp());

		// Token: 0x04002694 RID: 9876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002695 RID: 9877
		public const int SkillIdFieldNumber = 12;

		// Token: 0x04002696 RID: 9878
		private uint skillId_;

		// Token: 0x04002697 RID: 9879
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04002698 RID: 9880
		private uint retcode_;
	}
}
