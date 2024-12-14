using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008DB RID: 2267
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusStartRaidScRsp : IMessage<HeliobusStartRaidScRsp>, IMessage, IEquatable<HeliobusStartRaidScRsp>, IDeepCloneable<HeliobusStartRaidScRsp>, IBufferMessage
	{
		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x0010E7DD File Offset: 0x0010C9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusStartRaidScRsp> Parser
		{
			get
			{
				return HeliobusStartRaidScRsp._parser;
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x0010E7E4 File Offset: 0x0010C9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusStartRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x0010E7F6 File Offset: 0x0010C9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusStartRaidScRsp.Descriptor;
			}
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x0010E7FD File Offset: 0x0010C9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidScRsp()
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0010E808 File Offset: 0x0010CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidScRsp(HeliobusStartRaidScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x0010E854 File Offset: 0x0010CA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusStartRaidScRsp Clone()
		{
			return new HeliobusStartRaidScRsp(this);
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x0010E85C File Offset: 0x0010CA5C
		// (set) Token: 0x06006520 RID: 25888 RVA: 0x0010E864 File Offset: 0x0010CA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06006521 RID: 25889 RVA: 0x0010E86D File Offset: 0x0010CA6D
		// (set) Token: 0x06006522 RID: 25890 RVA: 0x0010E875 File Offset: 0x0010CA75
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

		// Token: 0x06006523 RID: 25891 RVA: 0x0010E87E File Offset: 0x0010CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusStartRaidScRsp);
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x0010E88C File Offset: 0x0010CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusStartRaidScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x0010E8DC File Offset: 0x0010CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
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

		// Token: 0x06006526 RID: 25894 RVA: 0x0010E931 File Offset: 0x0010CB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x0010E939 File Offset: 0x0010CB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x0010E944 File Offset: 0x0010CB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.scene_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Scene);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x0010E9A0 File Offset: 0x0010CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
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

		// Token: 0x0600652A RID: 25898 RVA: 0x0010E9F8 File Offset: 0x0010CBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusStartRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new OIIOLCPBLCF();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x0010EA60 File Offset: 0x0010CC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0010EA6C File Offset: 0x0010CC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 120U)
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
					if (this.scene_ == null)
					{
						this.Scene = new OIIOLCPBLCF();
					}
					input.ReadMessage(this.Scene);
				}
			}
		}

		// Token: 0x040026EA RID: 9962
		private static readonly MessageParser<HeliobusStartRaidScRsp> _parser = new MessageParser<HeliobusStartRaidScRsp>(() => new HeliobusStartRaidScRsp());

		// Token: 0x040026EB RID: 9963
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026EC RID: 9964
		public const int SceneFieldNumber = 10;

		// Token: 0x040026ED RID: 9965
		private OIIOLCPBLCF scene_;

		// Token: 0x040026EE RID: 9966
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040026EF RID: 9967
		private uint retcode_;
	}
}
