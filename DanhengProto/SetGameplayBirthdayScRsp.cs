using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FB RID: 4347
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGameplayBirthdayScRsp : IMessage<SetGameplayBirthdayScRsp>, IMessage, IEquatable<SetGameplayBirthdayScRsp>, IDeepCloneable<SetGameplayBirthdayScRsp>, IBufferMessage
	{
		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x00208E1C File Offset: 0x0020701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGameplayBirthdayScRsp> Parser
		{
			get
			{
				return SetGameplayBirthdayScRsp._parser;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x00208E23 File Offset: 0x00207023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGameplayBirthdayScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600C1D5 RID: 49621 RVA: 0x00208E35 File Offset: 0x00207035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGameplayBirthdayScRsp.Descriptor;
			}
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x00208E3C File Offset: 0x0020703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayScRsp()
		{
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x00208E44 File Offset: 0x00207044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayScRsp(SetGameplayBirthdayScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.birthday_ = other.birthday_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00208E75 File Offset: 0x00207075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayScRsp Clone()
		{
			return new SetGameplayBirthdayScRsp(this);
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600C1D9 RID: 49625 RVA: 0x00208E7D File Offset: 0x0020707D
		// (set) Token: 0x0600C1DA RID: 49626 RVA: 0x00208E85 File Offset: 0x00207085
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

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600C1DB RID: 49627 RVA: 0x00208E8E File Offset: 0x0020708E
		// (set) Token: 0x0600C1DC RID: 49628 RVA: 0x00208E96 File Offset: 0x00207096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Birthday
		{
			get
			{
				return this.birthday_;
			}
			set
			{
				this.birthday_ = value;
			}
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x00208E9F File Offset: 0x0020709F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGameplayBirthdayScRsp);
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x00208EAD File Offset: 0x002070AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGameplayBirthdayScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Birthday == other.Birthday && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x00208EEC File Offset: 0x002070EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Birthday != 0U)
			{
				num ^= this.Birthday.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x00208F44 File Offset: 0x00207144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x00208F4C File Offset: 0x0020714C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x00208F58 File Offset: 0x00207158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Birthday != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Birthday);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x00208FB4 File Offset: 0x002071B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Birthday != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x0020900C File Offset: 0x0020720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGameplayBirthdayScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Birthday != 0U)
			{
				this.Birthday = other.Birthday;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x0020905C File Offset: 0x0020725C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x00209068 File Offset: 0x00207268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Birthday = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E76 RID: 20086
		private static readonly MessageParser<SetGameplayBirthdayScRsp> _parser = new MessageParser<SetGameplayBirthdayScRsp>(() => new SetGameplayBirthdayScRsp());

		// Token: 0x04004E77 RID: 20087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E78 RID: 20088
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04004E79 RID: 20089
		private uint retcode_;

		// Token: 0x04004E7A RID: 20090
		public const int BirthdayFieldNumber = 5;

		// Token: 0x04004E7B RID: 20091
		private uint birthday_;
	}
}
