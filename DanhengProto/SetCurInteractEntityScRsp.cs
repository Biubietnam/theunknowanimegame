using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E3 RID: 4323
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetCurInteractEntityScRsp : IMessage<SetCurInteractEntityScRsp>, IMessage, IEquatable<SetCurInteractEntityScRsp>, IDeepCloneable<SetCurInteractEntityScRsp>, IBufferMessage
	{
		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600C0C3 RID: 49347 RVA: 0x00206830 File Offset: 0x00204A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetCurInteractEntityScRsp> Parser
		{
			get
			{
				return SetCurInteractEntityScRsp._parser;
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600C0C4 RID: 49348 RVA: 0x00206837 File Offset: 0x00204A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetCurInteractEntityScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600C0C5 RID: 49349 RVA: 0x00206849 File Offset: 0x00204A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetCurInteractEntityScRsp.Descriptor;
			}
		}

		// Token: 0x0600C0C6 RID: 49350 RVA: 0x00206850 File Offset: 0x00204A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityScRsp()
		{
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x00206858 File Offset: 0x00204A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityScRsp(SetCurInteractEntityScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0C8 RID: 49352 RVA: 0x0020687D File Offset: 0x00204A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityScRsp Clone()
		{
			return new SetCurInteractEntityScRsp(this);
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600C0C9 RID: 49353 RVA: 0x00206885 File Offset: 0x00204A85
		// (set) Token: 0x0600C0CA RID: 49354 RVA: 0x0020688D File Offset: 0x00204A8D
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

		// Token: 0x0600C0CB RID: 49355 RVA: 0x00206896 File Offset: 0x00204A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetCurInteractEntityScRsp);
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x002068A4 File Offset: 0x00204AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetCurInteractEntityScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0CD RID: 49357 RVA: 0x002068D4 File Offset: 0x00204AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C0CE RID: 49358 RVA: 0x00206913 File Offset: 0x00204B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x0020691B File Offset: 0x00204B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x00206924 File Offset: 0x00204B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x00206958 File Offset: 0x00204B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x00206996 File Offset: 0x00204B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetCurInteractEntityScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x002069C7 File Offset: 0x00204BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0D4 RID: 49364 RVA: 0x002069D0 File Offset: 0x00204BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E22 RID: 20002
		private static readonly MessageParser<SetCurInteractEntityScRsp> _parser = new MessageParser<SetCurInteractEntityScRsp>(() => new SetCurInteractEntityScRsp());

		// Token: 0x04004E23 RID: 20003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E24 RID: 20004
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04004E25 RID: 20005
		private uint retcode_;
	}
}
