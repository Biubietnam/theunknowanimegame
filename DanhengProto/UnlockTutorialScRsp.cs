using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D3 RID: 5075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockTutorialScRsp : IMessage<UnlockTutorialScRsp>, IMessage, IEquatable<UnlockTutorialScRsp>, IDeepCloneable<UnlockTutorialScRsp>, IBufferMessage
	{
		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00259B15 File Offset: 0x00257D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockTutorialScRsp> Parser
		{
			get
			{
				return UnlockTutorialScRsp._parser;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0600E239 RID: 57913 RVA: 0x00259B1C File Offset: 0x00257D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00259B2E File Offset: 0x00257D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockTutorialScRsp.Descriptor;
			}
		}

		// Token: 0x0600E23B RID: 57915 RVA: 0x00259B35 File Offset: 0x00257D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialScRsp()
		{
		}

		// Token: 0x0600E23C RID: 57916 RVA: 0x00259B40 File Offset: 0x00257D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialScRsp(UnlockTutorialScRsp other) : this()
		{
			this.tutorial_ = ((other.tutorial_ != null) ? other.tutorial_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E23D RID: 57917 RVA: 0x00259B8C File Offset: 0x00257D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialScRsp Clone()
		{
			return new UnlockTutorialScRsp(this);
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0600E23E RID: 57918 RVA: 0x00259B94 File Offset: 0x00257D94
		// (set) Token: 0x0600E23F RID: 57919 RVA: 0x00259B9C File Offset: 0x00257D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Tutorial Tutorial
		{
			get
			{
				return this.tutorial_;
			}
			set
			{
				this.tutorial_ = value;
			}
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x0600E240 RID: 57920 RVA: 0x00259BA5 File Offset: 0x00257DA5
		// (set) Token: 0x0600E241 RID: 57921 RVA: 0x00259BAD File Offset: 0x00257DAD
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

		// Token: 0x0600E242 RID: 57922 RVA: 0x00259BB6 File Offset: 0x00257DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockTutorialScRsp);
		}

		// Token: 0x0600E243 RID: 57923 RVA: 0x00259BC4 File Offset: 0x00257DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockTutorialScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Tutorial, other.Tutorial) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E244 RID: 57924 RVA: 0x00259C14 File Offset: 0x00257E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.tutorial_ != null)
			{
				num ^= this.Tutorial.GetHashCode();
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

		// Token: 0x0600E245 RID: 57925 RVA: 0x00259C69 File Offset: 0x00257E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E246 RID: 57926 RVA: 0x00259C71 File Offset: 0x00257E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E247 RID: 57927 RVA: 0x00259C7C File Offset: 0x00257E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.tutorial_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Tutorial);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E248 RID: 57928 RVA: 0x00259CD4 File Offset: 0x00257ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.tutorial_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tutorial);
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

		// Token: 0x0600E249 RID: 57929 RVA: 0x00259D2C File Offset: 0x00257F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockTutorialScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.tutorial_ != null)
			{
				if (this.tutorial_ == null)
				{
					this.Tutorial = new Tutorial();
				}
				this.Tutorial.MergeFrom(other.Tutorial);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E24A RID: 57930 RVA: 0x00259D94 File Offset: 0x00257F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E24B RID: 57931 RVA: 0x00259DA0 File Offset: 0x00257FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tutorial_ == null)
						{
							this.Tutorial = new Tutorial();
						}
						input.ReadMessage(this.Tutorial);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059FA RID: 23034
		private static readonly MessageParser<UnlockTutorialScRsp> _parser = new MessageParser<UnlockTutorialScRsp>(() => new UnlockTutorialScRsp());

		// Token: 0x040059FB RID: 23035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059FC RID: 23036
		public const int TutorialFieldNumber = 10;

		// Token: 0x040059FD RID: 23037
		private Tutorial tutorial_;

		// Token: 0x040059FE RID: 23038
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040059FF RID: 23039
		private uint retcode_;
	}
}
