using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000993 RID: 2451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KEKABJPICIP : IMessage<KEKABJPICIP>, IMessage, IEquatable<KEKABJPICIP>, IDeepCloneable<KEKABJPICIP>, IBufferMessage
	{
		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06006DAC RID: 28076 RVA: 0x001253A3 File Offset: 0x001235A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KEKABJPICIP> Parser
		{
			get
			{
				return KEKABJPICIP._parser;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x001253AA File Offset: 0x001235AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KEKABJPICIPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x001253BC File Offset: 0x001235BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KEKABJPICIP.Descriptor;
			}
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x001253C3 File Offset: 0x001235C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KEKABJPICIP()
		{
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x001253CC File Offset: 0x001235CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KEKABJPICIP(KEKABJPICIP other) : this()
		{
			this.cELFGLFFEIG_ = ((other.cELFGLFFEIG_ != null) ? other.cELFGLFFEIG_.Clone() : null);
			this.eLNNEFOGPIF_ = other.eLNNEFOGPIF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x00125418 File Offset: 0x00123618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KEKABJPICIP Clone()
		{
			return new KEKABJPICIP(this);
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06006DB2 RID: 28082 RVA: 0x00125420 File Offset: 0x00123620
		// (set) Token: 0x06006DB3 RID: 28083 RVA: 0x00125428 File Offset: 0x00123628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KAKPHLOPDAN CELFGLFFEIG
		{
			get
			{
				return this.cELFGLFFEIG_;
			}
			set
			{
				this.cELFGLFFEIG_ = value;
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06006DB4 RID: 28084 RVA: 0x00125431 File Offset: 0x00123631
		// (set) Token: 0x06006DB5 RID: 28085 RVA: 0x00125439 File Offset: 0x00123639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJKIMHHJBJJ ELNNEFOGPIF
		{
			get
			{
				return this.eLNNEFOGPIF_;
			}
			set
			{
				this.eLNNEFOGPIF_ = value;
			}
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00125442 File Offset: 0x00123642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KEKABJPICIP);
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x00125450 File Offset: 0x00123650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KEKABJPICIP other)
		{
			return other != null && (other == this || (object.Equals(this.CELFGLFFEIG, other.CELFGLFFEIG) && this.ELNNEFOGPIF == other.ELNNEFOGPIF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x001254A0 File Offset: 0x001236A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cELFGLFFEIG_ != null)
			{
				num ^= this.CELFGLFFEIG.GetHashCode();
			}
			if (this.ELNNEFOGPIF != KJKIMHHJBJJ.EventBegin)
			{
				num ^= this.ELNNEFOGPIF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x001254FB File Offset: 0x001236FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x00125503 File Offset: 0x00123703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x0012550C File Offset: 0x0012370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ELNNEFOGPIF != KJKIMHHJBJJ.EventBegin)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ELNNEFOGPIF);
			}
			if (this.cELFGLFFEIG_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CELFGLFFEIG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x00125568 File Offset: 0x00123768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cELFGLFFEIG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CELFGLFFEIG);
			}
			if (this.ELNNEFOGPIF != KJKIMHHJBJJ.EventBegin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ELNNEFOGPIF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x001255C0 File Offset: 0x001237C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KEKABJPICIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cELFGLFFEIG_ != null)
			{
				if (this.cELFGLFFEIG_ == null)
				{
					this.CELFGLFFEIG = new KAKPHLOPDAN();
				}
				this.CELFGLFFEIG.MergeFrom(other.CELFGLFFEIG);
			}
			if (other.ELNNEFOGPIF != KJKIMHHJBJJ.EventBegin)
			{
				this.ELNNEFOGPIF = other.ELNNEFOGPIF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x00125628 File Offset: 0x00123828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x00125634 File Offset: 0x00123834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.cELFGLFFEIG_ == null)
						{
							this.CELFGLFFEIG = new KAKPHLOPDAN();
						}
						input.ReadMessage(this.CELFGLFFEIG);
					}
				}
				else
				{
					this.ELNNEFOGPIF = (KJKIMHHJBJJ)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A24 RID: 10788
		private static readonly MessageParser<KEKABJPICIP> _parser = new MessageParser<KEKABJPICIP>(() => new KEKABJPICIP());

		// Token: 0x04002A25 RID: 10789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A26 RID: 10790
		public const int CELFGLFFEIGFieldNumber = 11;

		// Token: 0x04002A27 RID: 10791
		private KAKPHLOPDAN cELFGLFFEIG_;

		// Token: 0x04002A28 RID: 10792
		public const int ELNNEFOGPIFFieldNumber = 7;

		// Token: 0x04002A29 RID: 10793
		private KJKIMHHJBJJ eLNNEFOGPIF_;
	}
}
