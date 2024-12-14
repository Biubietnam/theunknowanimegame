using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B7 RID: 4535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartMatchScRsp : IMessage<StartMatchScRsp>, IMessage, IEquatable<StartMatchScRsp>, IDeepCloneable<StartMatchScRsp>, IBufferMessage
	{
		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600CA88 RID: 51848 RVA: 0x0021F52D File Offset: 0x0021D72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartMatchScRsp> Parser
		{
			get
			{
				return StartMatchScRsp._parser;
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x0021F534 File Offset: 0x0021D734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartMatchScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600CA8A RID: 51850 RVA: 0x0021F546 File Offset: 0x0021D746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchScRsp.Descriptor;
			}
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x0021F54D File Offset: 0x0021D74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchScRsp()
		{
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x0021F558 File Offset: 0x0021D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchScRsp(StartMatchScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dIFNDEGMKNA_ = ((other.dIFNDEGMKNA_ != null) ? other.dIFNDEGMKNA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x0021F5A4 File Offset: 0x0021D7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchScRsp Clone()
		{
			return new StartMatchScRsp(this);
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600CA8E RID: 51854 RVA: 0x0021F5AC File Offset: 0x0021D7AC
		// (set) Token: 0x0600CA8F RID: 51855 RVA: 0x0021F5B4 File Offset: 0x0021D7B4
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

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600CA90 RID: 51856 RVA: 0x0021F5BD File Offset: 0x0021D7BD
		// (set) Token: 0x0600CA91 RID: 51857 RVA: 0x0021F5C5 File Offset: 0x0021D7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP DIFNDEGMKNA
		{
			get
			{
				return this.dIFNDEGMKNA_;
			}
			set
			{
				this.dIFNDEGMKNA_ = value;
			}
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x0021F5CE File Offset: 0x0021D7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchScRsp);
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x0021F5DC File Offset: 0x0021D7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.DIFNDEGMKNA, other.DIFNDEGMKNA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x0021F62C File Offset: 0x0021D82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num ^= this.DIFNDEGMKNA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x0021F681 File Offset: 0x0021D881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA96 RID: 51862 RVA: 0x0021F689 File Offset: 0x0021D889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x0021F694 File Offset: 0x0021D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dIFNDEGMKNA_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DIFNDEGMKNA);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x0021F6F0 File Offset: 0x0021D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DIFNDEGMKNA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x0021F748 File Offset: 0x0021D948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.dIFNDEGMKNA_ != null)
			{
				if (this.dIFNDEGMKNA_ == null)
				{
					this.DIFNDEGMKNA = new PGDACNIBFMP();
				}
				this.DIFNDEGMKNA.MergeFrom(other.DIFNDEGMKNA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x0021F7B0 File Offset: 0x0021D9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x0021F7BC File Offset: 0x0021D9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 104U)
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
					if (this.dIFNDEGMKNA_ == null)
					{
						this.DIFNDEGMKNA = new PGDACNIBFMP();
					}
					input.ReadMessage(this.DIFNDEGMKNA);
				}
			}
		}

		// Token: 0x040051AE RID: 20910
		private static readonly MessageParser<StartMatchScRsp> _parser = new MessageParser<StartMatchScRsp>(() => new StartMatchScRsp());

		// Token: 0x040051AF RID: 20911
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051B0 RID: 20912
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040051B1 RID: 20913
		private uint retcode_;

		// Token: 0x040051B2 RID: 20914
		public const int DIFNDEGMKNAFieldNumber = 9;

		// Token: 0x040051B3 RID: 20915
		private PGDACNIBFMP dIFNDEGMKNA_;
	}
}
