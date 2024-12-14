using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A5F RID: 2655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LoginActivityData : IMessage<LoginActivityData>, IMessage, IEquatable<LoginActivityData>, IDeepCloneable<LoginActivityData>, IBufferMessage
	{
		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x060075B5 RID: 30133 RVA: 0x00138861 File Offset: 0x00136A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LoginActivityData> Parser
		{
			get
			{
				return LoginActivityData._parser;
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x00138868 File Offset: 0x00136A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LoginActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x0013887A File Offset: 0x00136A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginActivityData.Descriptor;
			}
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00138881 File Offset: 0x00136A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginActivityData()
		{
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00138894 File Offset: 0x00136A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginActivityData(LoginActivityData other) : this()
		{
			this.hBDPCIHAOCH_ = other.hBDPCIHAOCH_.Clone();
			this.loginDays_ = other.loginDays_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x001388E1 File Offset: 0x00136AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginActivityData Clone()
		{
			return new LoginActivityData(this);
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x001388E9 File Offset: 0x00136AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HBDPCIHAOCH
		{
			get
			{
				return this.hBDPCIHAOCH_;
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x060075BC RID: 30140 RVA: 0x001388F1 File Offset: 0x00136AF1
		// (set) Token: 0x060075BD RID: 30141 RVA: 0x001388F9 File Offset: 0x00136AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LoginDays
		{
			get
			{
				return this.loginDays_;
			}
			set
			{
				this.loginDays_ = value;
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x060075BE RID: 30142 RVA: 0x00138902 File Offset: 0x00136B02
		// (set) Token: 0x060075BF RID: 30143 RVA: 0x0013890A File Offset: 0x00136B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00138913 File Offset: 0x00136B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginActivityData);
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00138924 File Offset: 0x00136B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginActivityData other)
		{
			return other != null && (other == this || (this.hBDPCIHAOCH_.Equals(other.hBDPCIHAOCH_) && this.LoginDays == other.LoginDays && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00138984 File Offset: 0x00136B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hBDPCIHAOCH_.GetHashCode();
			if (this.LoginDays != 0U)
			{
				num ^= this.LoginDays.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x001389EA File Offset: 0x00136BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x001389F2 File Offset: 0x00136BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x001389FC File Offset: 0x00136BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			this.hBDPCIHAOCH_.WriteTo(ref output, LoginActivityData._repeated_hBDPCIHAOCH_codec);
			if (this.LoginDays != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LoginDays);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00138A68 File Offset: 0x00136C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hBDPCIHAOCH_.CalculateSize(LoginActivityData._repeated_hBDPCIHAOCH_codec);
			if (this.LoginDays != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LoginDays);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00138AD4 File Offset: 0x00136CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoginActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.hBDPCIHAOCH_.Add(other.hBDPCIHAOCH_);
			if (other.LoginDays != 0U)
			{
				this.LoginDays = other.LoginDays;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00138B35 File Offset: 0x00136D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00138B40 File Offset: 0x00136D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						goto IL_3F;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_3F;
					}
					if (num == 112U)
					{
						this.LoginDays = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3F:
				this.hBDPCIHAOCH_.AddEntriesFrom(ref input, LoginActivityData._repeated_hBDPCIHAOCH_codec);
			}
		}

		// Token: 0x04002D41 RID: 11585
		private static readonly MessageParser<LoginActivityData> _parser = new MessageParser<LoginActivityData>(() => new LoginActivityData());

		// Token: 0x04002D42 RID: 11586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D43 RID: 11587
		public const int HBDPCIHAOCHFieldNumber = 7;

		// Token: 0x04002D44 RID: 11588
		private static readonly FieldCodec<uint> _repeated_hBDPCIHAOCH_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002D45 RID: 11589
		private readonly RepeatedField<uint> hBDPCIHAOCH_ = new RepeatedField<uint>();

		// Token: 0x04002D46 RID: 11590
		public const int LoginDaysFieldNumber = 14;

		// Token: 0x04002D47 RID: 11591
		private uint loginDays_;

		// Token: 0x04002D48 RID: 11592
		public const int IdFieldNumber = 4;

		// Token: 0x04002D49 RID: 11593
		private uint id_;
	}
}
