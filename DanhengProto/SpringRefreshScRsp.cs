using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001187 RID: 4487
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRefreshScRsp : IMessage<SpringRefreshScRsp>, IMessage, IEquatable<SpringRefreshScRsp>, IDeepCloneable<SpringRefreshScRsp>, IBufferMessage
	{
		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600C845 RID: 51269 RVA: 0x00219628 File Offset: 0x00217828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRefreshScRsp> Parser
		{
			get
			{
				return SpringRefreshScRsp._parser;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600C846 RID: 51270 RVA: 0x0021962F File Offset: 0x0021782F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRefreshScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600C847 RID: 51271 RVA: 0x00219641 File Offset: 0x00217841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRefreshScRsp.Descriptor;
			}
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x00219648 File Offset: 0x00217848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshScRsp()
		{
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x00219650 File Offset: 0x00217850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshScRsp(SpringRefreshScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00219675 File Offset: 0x00217875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshScRsp Clone()
		{
			return new SpringRefreshScRsp(this);
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600C84B RID: 51275 RVA: 0x0021967D File Offset: 0x0021787D
		// (set) Token: 0x0600C84C RID: 51276 RVA: 0x00219685 File Offset: 0x00217885
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

		// Token: 0x0600C84D RID: 51277 RVA: 0x0021968E File Offset: 0x0021788E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRefreshScRsp);
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x0021969C File Offset: 0x0021789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRefreshScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x002196CC File Offset: 0x002178CC
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

		// Token: 0x0600C850 RID: 51280 RVA: 0x0021970B File Offset: 0x0021790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x00219713 File Offset: 0x00217913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x0021971C File Offset: 0x0021791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C853 RID: 51283 RVA: 0x00219750 File Offset: 0x00217950
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

		// Token: 0x0600C854 RID: 51284 RVA: 0x0021978E File Offset: 0x0021798E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRefreshScRsp other)
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

		// Token: 0x0600C855 RID: 51285 RVA: 0x002197BF File Offset: 0x002179BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x002197C8 File Offset: 0x002179C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040050DD RID: 20701
		private static readonly MessageParser<SpringRefreshScRsp> _parser = new MessageParser<SpringRefreshScRsp>(() => new SpringRefreshScRsp());

		// Token: 0x040050DE RID: 20702
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050DF RID: 20703
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040050E0 RID: 20704
		private uint retcode_;
	}
}
