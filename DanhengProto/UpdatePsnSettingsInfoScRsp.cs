using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013ED RID: 5101
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdatePsnSettingsInfoScRsp : IMessage<UpdatePsnSettingsInfoScRsp>, IMessage, IEquatable<UpdatePsnSettingsInfoScRsp>, IDeepCloneable<UpdatePsnSettingsInfoScRsp>, IBufferMessage
	{
		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x0025CE0C File Offset: 0x0025B00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdatePsnSettingsInfoScRsp> Parser
		{
			get
			{
				return UpdatePsnSettingsInfoScRsp._parser;
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0600E36C RID: 58220 RVA: 0x0025CE13 File Offset: 0x0025B013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdatePsnSettingsInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x0025CE25 File Offset: 0x0025B025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePsnSettingsInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x0025CE2C File Offset: 0x0025B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoScRsp()
		{
		}

		// Token: 0x0600E36F RID: 58223 RVA: 0x0025CE34 File Offset: 0x0025B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoScRsp(UpdatePsnSettingsInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E370 RID: 58224 RVA: 0x0025CE59 File Offset: 0x0025B059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePsnSettingsInfoScRsp Clone()
		{
			return new UpdatePsnSettingsInfoScRsp(this);
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x0600E371 RID: 58225 RVA: 0x0025CE61 File Offset: 0x0025B061
		// (set) Token: 0x0600E372 RID: 58226 RVA: 0x0025CE69 File Offset: 0x0025B069
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

		// Token: 0x0600E373 RID: 58227 RVA: 0x0025CE72 File Offset: 0x0025B072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePsnSettingsInfoScRsp);
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x0025CE80 File Offset: 0x0025B080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePsnSettingsInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x0025CEB0 File Offset: 0x0025B0B0
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

		// Token: 0x0600E376 RID: 58230 RVA: 0x0025CEEF File Offset: 0x0025B0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x0025CEF7 File Offset: 0x0025B0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x0025CF00 File Offset: 0x0025B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x0025CF34 File Offset: 0x0025B134
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

		// Token: 0x0600E37A RID: 58234 RVA: 0x0025CF72 File Offset: 0x0025B172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePsnSettingsInfoScRsp other)
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

		// Token: 0x0600E37B RID: 58235 RVA: 0x0025CFA3 File Offset: 0x0025B1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x0025CFAC File Offset: 0x0025B1AC
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
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A65 RID: 23141
		private static readonly MessageParser<UpdatePsnSettingsInfoScRsp> _parser = new MessageParser<UpdatePsnSettingsInfoScRsp>(() => new UpdatePsnSettingsInfoScRsp());

		// Token: 0x04005A66 RID: 23142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A67 RID: 23143
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005A68 RID: 23144
		private uint retcode_;
	}
}
